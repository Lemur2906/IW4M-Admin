﻿using IW4MAdmin.Application.API.GameLogServer;
using RestEase;
using SharedLibraryCore;
using SharedLibraryCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using static SharedLibraryCore.Utilities;

namespace IW4MAdmin.Application.IO
{
    /// <summary>
    /// provides capibility of reading log files over HTTP
    /// </summary>
    class GameLogReaderHttp : IGameLogReader
    {
        readonly IEventParser Parser;
        readonly IGameLogServer Api;
        readonly string LogFile;

        public GameLogReaderHttp(string logFile, IEventParser parser)
        {
            LogFile = logFile;
            Parser = parser;
            Api = RestClient.For<IGameLogServer>(logFile);
        }

        public long Length => -1;

        public int UpdateInterval => 1000;

        public ICollection<GameEvent> ReadEventsFromLog(Server server, long fileSizeDiff, long startPosition)
        {
#if DEBUG == true
            server.Logger.WriteDebug($"Begin reading {fileSizeDiff} from http log");
#endif
            var events = new List<GameEvent>();
            string b64Path = server.LogPath.ToBase64UrlSafeString();
            var response = Api.Log(b64Path).Result;

            if (!response.Success)
            {
                server.Logger.WriteError($"Could not get log server info of {LogFile}/{b64Path} ({server.LogPath})");
            }

            // parse each line
            foreach (string eventLine in response.Data.Split(Environment.NewLine))
            {
                if (eventLine.Length > 0)
                {
                    try
                    {
                        var e = Parser.GetEvent(server, eventLine);
#if DEBUG == true
                        server.Logger.WriteDebug($"Parsed event with id {e.Id}  from http");
#endif
                        events.Add(e);
                    }

                    catch (Exception e)
                    {
                        Program.ServerManager.GetLogger().WriteWarning("Could not properly parse event line");
                        Program.ServerManager.GetLogger().WriteDebug(e.Message);
                        Program.ServerManager.GetLogger().WriteDebug(eventLine);
                    }
                }
            }

            return events;
        }
    }
}

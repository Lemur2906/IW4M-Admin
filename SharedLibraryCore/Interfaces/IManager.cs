﻿using System.Collections.Generic;
using System.Threading.Tasks;

using SharedLibraryCore.Objects;
using SharedLibraryCore.Services;
using SharedLibraryCore.Configuration;
using System.Reflection;

namespace SharedLibraryCore.Interfaces
{
    public interface IManager
    {
        Task Init();
        Task Start();
        void Stop();
        ILogger GetLogger();
        IList<Server> GetServers();
        IList<Command> GetCommands();
        IList<Helpers.MessageToken> GetMessageTokens();
        IList<Player> GetActiveClients();
        IConfigurationHandler<ApplicationConfiguration> GetApplicationSettings();
        ClientService GetClientService();
        AliasService GetAliasService();
        PenaltyService GetPenaltyService();
        IDictionary<int, Player> GetPrivilegedClients();
        IEventApi GetEventApi();
        /// <summary>
        /// Get the event handlers
        /// </summary>
        /// <returns>EventHandler for the manager</returns>
        IEventHandler GetEventHandler();
        /// <summary>
        /// Signal to the manager that event(s) needs to be processed
        /// </summary>
        void SetHasEvent();
        bool ShutdownRequested();
        IList<Assembly> GetPluginAssemblies();
    }
}

﻿using Microsoft.Extensions.Logging;
using Stats.Client.Abstractions;
using Stats.Client.Game;
using System.Collections.Generic;
using System.Linq;
using IW4MAdmin.Plugins.Stats.Config;
using SharedLibraryCore;
using SharedLibraryCore.Interfaces;
using Stats.Config;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Stats.Client
{
    public class WeaponNameParser : IWeaponNameParser
    {
        private readonly ILogger _logger;
        private readonly StatsConfiguration _config;

        public WeaponNameParser(ILogger<WeaponNameParser> logger, IConfigurationHandler<StatsConfiguration> config)
        {
            _logger = logger;
            _config = config.Configuration();
        }

        public WeaponInfo Parse(string weaponName, Server.Game gameName)
        {
            var configForGame = _config.WeaponNameParserConfigurations
                ?.FirstOrDefault(config => config.Game == gameName) ?? new WeaponNameParserConfiguration()
            {
                Game = gameName
            };

            var splitWeaponName = weaponName.Split(configForGame.Delimiters);

            if (!splitWeaponName.Any())
            {
                _logger.LogError("Could not parse weapon name {Weapon}", weaponName);

                return new WeaponInfo()
                {
                    Name = "Unknown"
                };
            }

            // remove the _mp suffix
            var filtered = splitWeaponName
                .Where(part => part != configForGame.WeaponSuffix && part != configForGame.WeaponPrefix)
                .ToList();
            var baseName = filtered.First();
            var attachments = new List<string>();

            if (filtered.Count() > 1)
            {
                attachments.AddRange(filtered.Skip(1));
            }

            var weaponInfo = new WeaponInfo()
            {
                RawName = weaponName,
                Name = baseName,
                Attachments = attachments.Select(attachment => new AttachmentInfo()
                {
                    Name = attachment
                }).ToList()
            };

            return weaponInfo;
        }
    }
}
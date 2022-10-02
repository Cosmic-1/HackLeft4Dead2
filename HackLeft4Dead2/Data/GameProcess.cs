﻿using MemoryManagement;
using System.Diagnostics;

namespace HackLeft4Dead2.Data
{
    public class GameProcess : ThreadBase
    {
        private const string
             PROCESS_LEFT4DEAD2 = "left4dead2",
             MODULE_CLIENT = "client.dll",
            MODULE_ENGINE = "engine.dll";

        public bool IsWorkingGame => !ProcessGame?.HasExited ?? false;

        public Process? ProcessGame { get; private set; }
        public ProcessModuleExtension? ModuleClient { get; private set; }
        public ProcessModuleExtension? ModuleEngine { get; private set; }


        public bool SearchProcessAndModules()
        {
            if (ProcessGame is null)
            {
                var process = ProcessExtension.GetSingleProcessByName(PROCESS_LEFT4DEAD2);
                ProcessGame = process;
            }

            if (ProcessGame is null || IsWorkingGame is false)
            {
                return false;
            }


            if (ModuleClient is null)
            {
                var client = ProcessGame.GetProcessModuleExtensionByName(MODULE_CLIENT);
                ModuleClient = client;
            }

            if (ModuleClient is null || IsWorkingGame is false)
            {
                return false;
            }

            if (ModuleEngine is null)
            {
                var engine = ProcessGame.GetProcessModuleExtensionByName(MODULE_ENGINE);
                ModuleEngine = engine;
            }

            if (ModuleEngine is null || IsWorkingGame is false)
            {
                return false;
            }

            return true;
        }

        public override void Dispose()
        {
            ProcessGame?.Dispose();
            ModuleClient?.Dispose();
            ModuleEngine?.Dispose();
            base.Dispose();
        }

        public override void Update()
        {
            if (IsWorkingGame is false)
            {
                SearchProcessAndModules();
            }
        }
    }
}

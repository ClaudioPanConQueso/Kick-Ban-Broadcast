using CommandSystem;
using System;

namespace SCPSL.Commands
{
    class Deny : ICommand
    {
        public string Command { get; } = "deny";

        public string[] Aliases { get; } = { };

        public string Description { get; } = "idk";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "hmmmmmmmmm";
            return false;
        }
    }
}

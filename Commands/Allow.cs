using CommandSystem;
using System;

namespace SCPSL.Commands
{
    class Allow : ICommand
    {
        public string Command { get; } = "allow";

        public string[] Aliases { get; } = { };

        public string Description { get; } = "yes";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "is ok";
            return true;
        }
    }
}

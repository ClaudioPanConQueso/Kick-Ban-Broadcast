using CommandSystem;
using System;

namespace SCPSL.Commands
{
    class yourmomTroll : ICommand
    {
        public string Command { get; } = "amogus";

        public string[] Aliases { get; } = { };

        public string Description { get; } = "idk";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "sus?";
            return false;
        }
    }
}

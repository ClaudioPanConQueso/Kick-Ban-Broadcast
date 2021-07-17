using System.ComponentModel;
using Exiled.API.Interfaces;

namespace SCPSL
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Text which will appear when someone is kicked! {player} will be changed per player username, and {reason} will be changed per kick reason.")]
        public string KickBroadcast { get; set; } = "{player} has been kicked from the server. reason: {reason}";

        [Description("Text will C.A.S.S.I.E make something, (leave in blank to disable)")]
        public string cassiekick { get; set; } = "A user has been successfully terminated from the facility";

        [Description("Text will C.A.S.S.I.E make something, (leave in blank to disable)")]
        public string cassieban { get; set; } = "A user has been successfully terminated from the facility";

        [Description("Text which will appear when someone is banned! {player} will be changed per player username, and {reason} will be changed per ban reason.")]
        public string BanBroadcast { get; set; } = "{player} has been banned from the server. reason: {reason}";
    }
}

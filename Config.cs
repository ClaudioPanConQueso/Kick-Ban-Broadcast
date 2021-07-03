using System.ComponentModel;
using Exiled.API.Interfaces;

namespace SCPSL
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Text which will appear when someone is kicked! {player} will be changed per player username")]
        public string KickBroadcast { get; set; } = "{player} has been kicked from the server!";

        [Description("Text which will appear when someone is banned! {player} will be changed per player username")]
        public string BanBroadcast { get; set; } = "{player} has been banned from the server.";
    }
}

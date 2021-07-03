using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace SCPSL.Handlers
{
    class Player
    {
        public void OnKicked(KickedEventArgs ev)
        {
            string message = Si.Instance.Config.KickBroadcast.Replace(oldValue: "{player}", newValue: ev.Player.Nickname);
            Map.Broadcast(duration:5, message);
        }

        public void OnBanned (BannedEventArgs ev)
        {
            string message = Si.Instance.Config.BanBroadcast.Replace(oldValue: "{player}", newValue: ev.Player.Nickname);
            Map.Broadcast(duration: 5, message);
        }
    }
}

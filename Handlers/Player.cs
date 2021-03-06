using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace SCPSL.Handlers
{
    class Player
    {
        public void OnKicked(KickedEventArgs ev)
        {
            string message = Si.Instance.Config.KickBroadcast.Replace("{player}", ev.Target.Nickname).Replace("{reason}", ev.Reason);
            string cassiekick = Si.Instance.Config.cassiekick;
            Map.Broadcast(duration: 3, message);
            Cassie.Message(cassiekick);
        }

        public void OnBanned (BannedEventArgs ev)
        {
            string message = Si.Instance.Config.BanBroadcast.Replace("{player}", ev.Target.Nickname).Replace("{reason}", ev.Details.Reason);
            string cassieban = Si.Instance.Config.cassieban;
            Map.Broadcast(duration: 3, message);
            Cassie.Message(cassieban);
        }
    }
}

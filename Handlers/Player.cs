using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace SCPSL.Handlers
{
    class Player
    {
        public void OnKicked(KickedEventArgs ev)
        {
            string message = Si.Instance.Config.KickBroadcast.Replace(oldValue: "{player}", newValue: ev.Target.Nickname);
            string cassiekick = Si.Instance.Config.cassiekick;
            Map.Broadcast(duration: 3, message);
            Cassie.Message(cassiekick);
        }

        public void OnBanned (BannedEventArgs ev)
        {
            string message = Si.Instance.Config.BanBroadcast.Replace(oldValue: "{player}", newValue: ev.Target.Nickname);
            string cassieban = Si.Instance.Config.cassieban;
            Map.Broadcast(duration: 3, message);
            Cassie.Message(cassieban);
        }
    }
}

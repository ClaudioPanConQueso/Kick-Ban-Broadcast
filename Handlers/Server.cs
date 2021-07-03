using Exiled.API.Features;

namespace SCPSL.Handlers
{
    class Server
    {
        public bool IsEnabled { get; set; } = false;

        public void OnWaitingForPlayers()
        {
            Log.Info(message: "Waiting players!");
        }
    }
}

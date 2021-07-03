using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using Player = Exiled.Events.Handlers.Player;

namespace SCPSL
{
    public class Si : Plugin<Config>
    {
        private static readonly Lazy<Si> LazyInstance = new Lazy<Si>(valueFactory:() => new Si());
        public static Si Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Player player;

        private Si ()
        {
        }

        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player();

            Player.Kicked += player.OnKicked;
            Player.Banned += player.OnBanned;
        }

        public void UnregisterEvents()
        {
            Player.Kicked -= player.OnKicked;
            Player.Banned -= player.OnBanned;

            player = null;
        }
    }
}

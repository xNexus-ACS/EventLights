using Exiled.API.Features;
using System;
using ServerHandler = Exiled.Events.Handlers.Server;

namespace OctoberLights
{
    public class Plugin : Plugin<Cfg>
    {
        public static Plugin Instance;
        public override string Author { get; } = "xNexus";
        public override string Name { get; } = "October Lights";
        public override string Prefix { get; } = "October Lights";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 5);
        public OctoberLightsEvents events;

        public override void OnEnabled()
        {
            Instance = this;
            events = new OctoberLightsEvents();
            Log.Info("OctoberLights Loaded, Enjoy Halloween");

            ServerHandler.RoundStarted += events.OnRoundStarted;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            events = null;

            ServerHandler.RoundStarted -= events.OnRoundStarted;

            base.OnDisabled();
        }
    }
}

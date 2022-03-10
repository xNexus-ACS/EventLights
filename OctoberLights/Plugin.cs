using Exiled.API.Features;
using System;
using EventLightsHandler = Exiled.Events.Handlers.Server;

namespace OctoberLights
{
    public class Plugin : Plugin<Cfg>
    {
        public static Plugin Instance;
        public override string Author { get; } = "xNexus-ACS";
        public override string Name { get; } = "EventLights";
        public override string Prefix { get; } = "event_lights";
        public override Version Version { get; } = new Version(2, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(4, 2, 5);
        public EventLightsEvents events;

        public override void OnEnabled()
        {
            Instance = this;
            events = new EventLightsEvents();

            EventLightsHandler.RoundStarted += events.OnRoundStarted;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            EventLightsHandler.RoundStarted -= events.OnRoundStarted;

            events = null;
            base.OnDisabled();
        }
    }
}

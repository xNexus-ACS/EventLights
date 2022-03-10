using Exiled.API.Enums;
using Exiled.API.Features;
using UnityEngine;

namespace OctoberLights
{
    public class EventLightsEvents
    {
        public void OnRoundStarted()
        {
            if (Plugin.Instance.Config.SpookyLights)
            {
                foreach (Room room in Room.List)
                {
                    if (room.Zone == ZoneType.LightContainment)
                    {
                        room.Color = new Color(1, 165 / 255f, 0);
                    }
                    if (room.Zone == ZoneType.HeavyContainment)
                    {
                        room.Color = new Color(1, 165 / 255f, 0);
                    }
                    if (room.Zone == ZoneType.Entrance)
                    {
                        room.Color = new Color(1, 165 / 255f, 0);
                    }
                }
            }
            if (Plugin.Instance.Config.ChristmasLights)
            {
                foreach (Room room in Room.List)
                {
                    if (room.Zone == ZoneType.LightContainment)
                    {
                        room.Color = new Color(0, 183 / 235f, 1);
                    }
                    if (room.Zone == ZoneType.HeavyContainment)
                    {
                        room.Color = new Color(0, 183 / 235f, 1);
                    }
                    if (room.Zone == ZoneType.Entrance)
                    {
                        room.Color = new Color(0, 183 / 235f, 1);
                    }
                }
            }
        }
    }
}

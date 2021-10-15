﻿using Exiled.API.Enums;
using Exiled.API.Features;
using UnityEngine;

namespace OctoberLights
{
    public class OctoberLightsEvents
    {
        public void OnRoundStarted()
        {
            foreach (Room room in Map.Rooms)
            {
                if (room.Zone == ZoneType.LightContainment)
                {
                    room.Color = new Color(1, 165 / 255f, 0);
                }
            }
        }
    }
}
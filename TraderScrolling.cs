﻿using BepInEx;
using BepInEx.Configuration;

namespace TraderScrolling
{
    [BepInPlugin("com.jero.Kaeno-TraderScrolling", "Kaeno-TraderScrolling", "2.0.0")]
    public class TraderScrolling : BaseUnityPlugin
    {
        internal static ConfigEntry<float> ScrollWheelSpeed { get; set; }
        
        private void Start()
        {
            InitConfiguration();
            new TraderScrollingPatch().Enable();
            new PlayerCardPatch().Enable();
        }

        private void InitConfiguration()
        {
            ScrollWheelSpeed = Config.Bind("Config", "Scroll Wheel Speed", 30f, "Adjusts scrolling speed when using mousewheel");
        }
    }
}

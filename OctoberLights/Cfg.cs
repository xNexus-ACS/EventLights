using System.ComponentModel;
using Exiled.API.Interfaces;

namespace OctoberLights
{
    public class Cfg : IConfig
    {
        [Description("Is the plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;
    }
}

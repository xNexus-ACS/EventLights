using System.ComponentModel;
using Exiled.API.Interfaces;

namespace OctoberLights
{
    public class Cfg : IConfig
    {
        [Description("Is the plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Enable Spooky Lights? (Default: false | Dont enable Spooky and Christmas at the same time)")]
        public bool SpookyLights { get; set; } = false;
        [Description("Enable Christmas Lights? (Default: false | Dont enable Spooky and Christmas at the same time)")]
        public bool ChristmasLights { get; set; } = false;
    }
}

using Nitrox_PublixExtension.Core;
using Nitrox_PublixExtension.Core.Plugin;
using Nitrox_PublixExtension.Core.Plugin.Attributes;
using NitroxModel.Logger;
using Publix_ExamplePlugin.EventListeners;

namespace Publix_ExamplePlugin
{
    [PluginInfo("dev.drperky.exampleplugin", "Example Plugin", "0.1", "1.0.0")]
    [PluginDescription("Example Plugin For PublixExtension")] //Description isnt used at the time of writing this, so its optional
    public class ExamplePlugin : BasePlugin
    {
        public override void OnEnable()
        {
            this.GetLogger().Info("Plugin Loaded :)");

            Publix.getEventManager().Register(this, new ExampleEventListener(this));
        }
        public override void OnDisable() { }
    }
}

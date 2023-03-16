using BepInEx;
using BepInEx.Logging;

namespace UnityLongPathPlugin
{


    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Log;

        private void Awake()
        {
            Plugin.Log = base.Logger;

            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            Patcher.DoPatching();

        }
    }
}

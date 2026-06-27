using BepInEx;
using BepInEx.Logging;

namespace UnityLongPathPlugin
{


    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Log;

        private void Awake()
        {
            Plugin.Log = base.Logger;

            // Plugin startup logic
            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

            Patcher.DoPatching();

        }
    }
}

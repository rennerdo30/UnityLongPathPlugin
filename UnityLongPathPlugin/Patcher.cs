using HarmonyLib;
using System;
using System.Diagnostics;
using static HarmonyLib.AccessTools;

namespace UnityLongPathPlugin
{
    public static class Patcher
    {
        // make sure DoPatching() is called at start either by
        // the mod loader or by your injector

        public static void DoPatching()
        {
            Plugin.Log.LogInfo($"starting patching...");

            var harmony = new Harmony("dev.renner.patch");
            harmony.PatchAll();
        }


    }

#if false
    [HarmonyPatch(typeof(System.IO.File))]
    class Patch
    {

        [HarmonyPatch(typeof(System.IO.File), nameof(System.IO.File.Move))]
        static void Move(string sourceFileName, string destFileName)
        {
            Plugin.Log.LogDebug($"using patched move: '{sourceFileName}' to '{destFileName}'");
            Alphaleonis.Win32.Filesystem.File.Move(sourceFileName, destFileName);
        }

    }
#endif

#if true
    [HarmonyPatch(typeof(System.IO.File))]
    [HarmonyPatch(nameof(System.IO.File.Move))]
    class FileMove
    {
        static bool Prefix(string sourceFileName, string destFileName)
        {
            Plugin.Log.LogDebug($"using patched move: '{sourceFileName}' to '{destFileName}'");

            try
            {
                LongFile.Move(sourceFileName, destFileName);
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError($"error during move: '{ex.Message}");
                Plugin.Log.LogError(ex.ToString());
                return true;
            }


            return false;
        }

    }
#endif
}

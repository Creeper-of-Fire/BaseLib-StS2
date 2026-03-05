using BaseMod2.Abstracts;
using HarmonyLib;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Relics;

namespace BaseMod2.Patches;

[HarmonyPatch(typeof(TouchOfOrobas), nameof(TouchOfOrobas.GetUpgradedStarterRelic))]
class StarterUpgradePatches
{
    [HarmonyPrefix]
    static bool CustomStarterUpgrade(RelicModel starterRelic, ref RelicModel __result)
    {
        if (starterRelic is CustomRelicModel customRelic)
        {
            __result = customRelic.GetUpgradeReplacement();
            return __result == null;
        }
        return true;
    }
}

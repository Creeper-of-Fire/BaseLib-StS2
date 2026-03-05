using BaseMod2.Abstracts;
using BaseMod2.Extensions;
using HarmonyLib;
using MegaCrit.Sts2.Core.Models;
using System;

namespace BaseMod2.Patches;

[HarmonyPatch(typeof(ModelDb), nameof(ModelDb.GetEntry))]
public class PrefixIdPatch
{

    [HarmonyPostfix]
    static string AdjustID(string __result, Type type)
    {
        if (type.IsAssignableTo(typeof(ICustomModel)))
        {
            //MainFile.Logger.Info(s);
            return type.GetPrefix() + __result;
        }
        return __result;
    }
}

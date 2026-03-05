using BaseMod2.Patches;
using MegaCrit.Sts2.Core.Models;
using System.Collections.Generic;

namespace BaseMod2.Abstracts;

public abstract class CustomPotionPoolModel : PotionPoolModel, ICustomModel
{
    public CustomPotionPoolModel()
    {
        if (IsShared) ModelDbSharedPotionPoolsPatch.Register(this);
    }

    public override IEnumerable<PotionModel> GenerateAllPotions() => []; //Content added through ModHelper.ConcatModelsFromMods

    /// <summary>
    /// You shouldn't need this (just use SharedRelicPool), but it is allowed.
    /// </summary>
    public virtual bool IsShared => false;
}

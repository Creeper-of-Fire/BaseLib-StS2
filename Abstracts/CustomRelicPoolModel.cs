using BaseMod2.Patches;
using MegaCrit.Sts2.Core.Models;
using System.Collections.Generic;

namespace BaseMod2.Abstracts;

public abstract class CustomRelicPoolModel : RelicPoolModel, ICustomModel
{
    public CustomRelicPoolModel()
    {
        if (IsShared) ModelDbSharedRelicPoolsPatch.Register(this);
    }

    public override IEnumerable<RelicModel> GenerateAllRelics() => []; //Content added through ModHelper.ConcatModelsFromMods

    /// <summary>
    /// You shouldn't need this (just use SharedRelicPool), but it is allowed.
    /// </summary>
    public virtual bool IsShared => false;
}

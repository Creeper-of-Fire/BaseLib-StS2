using Basis.Patches;
using MegaCrit.Sts2.Core.Models;

namespace Basis.Abstracts;

public abstract class CustomRelicModel : RelicModel, ICustomModel
{
    public virtual bool AutoAdd => true;
    public CustomRelicModel()
    {
        if (AutoAdd) CustomContentDictionary.AddModel(GetType());
    }

    public virtual RelicModel GetUpgradeReplacement() => null;
}

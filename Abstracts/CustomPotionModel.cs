using BaseMod2.Patches;
using MegaCrit.Sts2.Core.Models;

namespace BaseMod2.Abstracts;

public abstract class CustomPotionModel : PotionModel, ICustomModel
{
    public virtual bool AutoAdd => true;
    public CustomPotionModel()
    {
        if (AutoAdd) CustomContentDictionary.AddModel(GetType());
    }
}

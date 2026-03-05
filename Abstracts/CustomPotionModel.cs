using Basis.Patches;
using MegaCrit.Sts2.Core.Models;

namespace Basis.Abstracts;

public abstract class CustomPotionModel : PotionModel, ICustomModel
{
    public virtual bool AutoAdd => true;
    public CustomPotionModel()
    {
        if (AutoAdd) CustomContentDictionary.AddModel(GetType());
    }
}

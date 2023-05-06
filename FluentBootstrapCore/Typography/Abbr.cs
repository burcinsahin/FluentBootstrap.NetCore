using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Typography
{
    public class Abbr : Tag, IHasTextContent, IHasTitleAttribute
    {
        internal Abbr(BootstrapHelper helper)
            : base(helper, "abbr")
        {
        }
    }
}

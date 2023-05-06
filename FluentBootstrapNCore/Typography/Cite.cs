using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Typography
{
    public class Cite : Tag, IHasTextContent, IHasTitleAttribute
    {
        internal Cite(BootstrapHelper helper)
            : base(helper, "cite")
        {
        }
    }
}

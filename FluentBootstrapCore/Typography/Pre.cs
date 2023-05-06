using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Typography
{
    public class Pre : Tag, IHasTextContent
    {
        internal Pre(BootstrapHelper helper)
            : base(helper, "pre")
        {
        }
    }
}

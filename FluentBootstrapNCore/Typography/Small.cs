using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Typography
{
    public class Small : Tag, IHasTextContent
    {
        internal Small(BootstrapHelper helper)
            : base(helper, "small")
        {
        }
    }
}

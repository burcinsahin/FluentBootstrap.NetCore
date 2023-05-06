using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Forms
{
    public class HelpBlock : Tag, IHasTextContent
    {
        internal HelpBlock(BootstrapHelper helper)
            : base(helper, "div", Css.HelpBlock)
        {
        }
    }
}

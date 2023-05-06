using FluentBootstrapNCore.Icons;
using FluentBootstrapNCore.Interfaces;
using FluentBootstrapNCore.Links;

namespace FluentBootstrapNCore.Buttons
{
    public class LinkButton : Tag,
        IHasIconExtensions, IHasLinkExtensions, IHasButtonExtensions, IHasButtonStateExtensions, IHasTextContent
    {
        internal LinkButton(BootstrapHelper helper)
            : base(helper, "a", Css.Btn, Css.BtnDefault)
        {
            MergeAttribute("role", "button");
        }
    }
}

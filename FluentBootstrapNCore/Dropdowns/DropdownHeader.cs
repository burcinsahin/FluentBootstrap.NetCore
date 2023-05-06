using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Dropdowns
{
    public class DropdownHeader : Tag, IHasTextContent
    {
        internal DropdownHeader(BootstrapHelper helper)
            : base(helper, "li", Css.DropdownHeader)
        {
            MergeAttribute("role", "presentation");
        }
    }
}

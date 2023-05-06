using FluentBootstrapNCore.Dropdowns;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Buttons
{
    public class ButtonGroup : Tag,
        ICanCreate<Button>,
        ICanCreate<LinkButton>,
        ICanCreate<Dropdown>
    {
        internal ButtonGroup(BootstrapHelper helper)
            : base(helper, "div", Css.BtnGroup)
        {
        }
    }
}

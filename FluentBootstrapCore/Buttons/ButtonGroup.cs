using FluentBootstrapCore.Dropdowns;

namespace FluentBootstrapCore.Buttons
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

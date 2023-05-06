using FluentBootstrapNCore.Buttons;
using FluentBootstrapNCore.Dropdowns;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Forms
{
    public class InputGroupButton : Tag,
        ICanCreate<Button>,
        ICanCreate<Dropdown>
    {
        internal InputGroupButton(BootstrapHelper helper)
            : base(helper, "span", Css.InputGroupBtn)
        {
        }
    }
}

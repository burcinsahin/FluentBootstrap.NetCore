using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Buttons
{
    public class ButtonToolbar : Tag,
        ICanCreate<ButtonGroup>
    {
        internal ButtonToolbar(BootstrapHelper helper)
            : base(helper, "div", Css.BtnToolbar)
        {
            MergeAttribute("role", "toolbar");
        }
    }
}

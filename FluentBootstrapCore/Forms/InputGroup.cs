using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Forms
{
    public class InputGroup : Tag,
        ICanCreate<InputGroupAddon>,
        ICanCreate<InputGroupButton>
    {
        internal InputGroup(BootstrapHelper helper)
            : base(helper, "div", Css.InputGroup)
        {
        }
    }
}

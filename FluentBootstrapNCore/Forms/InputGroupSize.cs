using System.ComponentModel;

namespace FluentBootstrapNCore.Forms
{
    public enum InputGroupSize
    {
        [Description()]
        Default,
        [Description(Css.InputGroupLg)]
        Lg,
        [Description(Css.InputGroupSm)]
        Sm
    }
}

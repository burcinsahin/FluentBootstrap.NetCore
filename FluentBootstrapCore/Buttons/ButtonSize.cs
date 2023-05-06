using System.ComponentModel;

namespace FluentBootstrapNCore.Buttons
{
    public enum ButtonSize
    {
        [Description()]
        Default,
        [Description(Css.BtnLg)]
        Lg,
        [Description(Css.BtnSm)]
        Sm,
        [Description(Css.BtnXs)]
        Xs
    }
}

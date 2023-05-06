using System.ComponentModel;

namespace FluentBootstrapNCore.Buttons
{
    public enum ButtonGroupSize
    {
        [Description()]
        Default,
        [Description(Css.BtnGroupLg)]
        Lg,
        [Description(Css.BtnGroupSm)]
        Sm,
        [Description(Css.BtnGroupXs)]
        Xs
    }
}

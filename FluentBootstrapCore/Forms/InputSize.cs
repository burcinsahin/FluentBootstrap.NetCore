using System.ComponentModel;

namespace FluentBootstrapNCore.Forms
{
    public enum InputSize
    {
        [Description()]
        Default,
        [Description(Css.InputLg)]
        Lg,
        [Description(Css.InputSm)]
        Sm
    }
}

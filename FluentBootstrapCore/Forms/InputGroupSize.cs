using System.ComponentModel;

namespace FluentBootstrapCore
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

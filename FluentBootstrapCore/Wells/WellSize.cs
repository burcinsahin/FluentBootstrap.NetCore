using System.ComponentModel;

namespace FluentBootstrapNCore.Wells
{
    public enum WellSize
    {
        [Description()]
        Default,
        [Description(Css.WellLg)]
        Lg,
        [Description(Css.WellSm)]
        Sm
    }
}

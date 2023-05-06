using System.ComponentModel;

namespace FluentBootstrapNCore.Navbars
{
    public enum NavbarPosition
    {
        [Description()]
        Default,
        [Description(Css.NavbarFixedTop)]
        FixedTop,
        [Description(Css.NavbarFixedBottom)]
        FixedBottm,
        [Description(Css.NavbarStaticTop)]
        StaticTop
    }
}

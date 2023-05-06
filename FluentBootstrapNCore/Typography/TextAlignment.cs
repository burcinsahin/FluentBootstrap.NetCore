using System.ComponentModel;

namespace FluentBootstrapNCore.Typography
{
    public enum TextAlignment
    {
        [Description()]
        Default,
        [Description(Css.TextLeft)]
        Left,
        [Description(Css.TextCenter)]
        Center,
        [Description(Css.TextRight)]
        Right,
        [Description(Css.TextJustify)]
        Justify,
        [Description(Css.TextNowrap)]
        Nowrap
    }
}

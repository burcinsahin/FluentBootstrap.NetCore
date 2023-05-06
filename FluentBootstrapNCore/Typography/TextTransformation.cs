using System.ComponentModel;

namespace FluentBootstrapNCore.Typography
{
    public enum TextTransformation
    {
        [Description()]
        None,
        [Description(Css.TextLowercase)]
        Lowercase,
        [Description(Css.TextUppercase)]
        Uppercase,
        [Description(Css.TextCapitalize)]
        Capitalize
    }
}

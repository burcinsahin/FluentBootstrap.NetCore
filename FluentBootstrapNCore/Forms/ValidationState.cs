using System.ComponentModel;

namespace FluentBootstrapNCore.Forms
{
    public enum ValidationState
    {
        [Description()]
        Default,
        [Description(Css.HasSuccess)]
        Success,
        [Description(Css.HasWarning)]
        Warning,
        [Description(Css.HasError)]
        Error
    }
}

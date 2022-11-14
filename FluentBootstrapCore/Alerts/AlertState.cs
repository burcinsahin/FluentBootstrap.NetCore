using System.ComponentModel;

namespace FluentBootstrapCore
{
    public enum AlertState
    {
        [Description(Css.AlertSuccess)]
        Success,
        [Description(Css.AlertInfo)]
        Info,
        [Description(Css.AlertWarning)]
        Warning,
        [Description(Css.AlertDanger)]
        Danger
    }
}

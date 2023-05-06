using System.ComponentModel;

namespace FluentBootstrapNCore
{
    public enum BackgroundState
    {
        [Description(Css.BgPrimary)]
        Primary,
        [Description(Css.BgSuccess)]
        Success,
        [Description(Css.BgInfo)]
        Info,
        [Description(Css.BgWarning)]
        Warning,
        [Description(Css.BgDanger)]
        Danger
    }
}

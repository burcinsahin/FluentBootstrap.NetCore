using System.ComponentModel;

namespace FluentBootstrapCore
{
    public enum TextState
    {
        [Description()]
        Default,
        [Description(Css.TextMuted)]
        Muted,
        [Description(Css.TextPrimary)]
        Primary,
        [Description(Css.TextSuccess)]
        Success,
        [Description(Css.TextInfo)]
        Info,
        [Description(Css.TextWarning)]
        Warning,
        [Description(Css.TextDanger)]
        Danger
    }
}

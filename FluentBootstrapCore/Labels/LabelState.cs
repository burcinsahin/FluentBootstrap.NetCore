using System.ComponentModel;

namespace FluentBootstrapNCore.Labels
{

    public enum LabelState
    {
        [Description(Css.LabelDefault)]
        Default,
        [Description(Css.LabelPrimary)]
        Primary,
        [Description(Css.LabelSuccess)]
        Success,
        [Description(Css.LabelInfo)]
        Info,
        [Description(Css.LabelWarning)]
        Warning,
        [Description(Css.LabelDanger)]
        Danger
    }
}

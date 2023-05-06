using System.ComponentModel;

namespace FluentBootstrapNCore.Tables
{
    public enum TableState
    {
        [Description()]
        Default,
        [Description(Css.Active)]
        Active,
        [Description(Css.Success)]
        Success,
        [Description(Css.Warning)]
        Warning,
        [Description(Css.Danger)]
        Danger,
        [Description(Css.Info)]
        Info
    }
}

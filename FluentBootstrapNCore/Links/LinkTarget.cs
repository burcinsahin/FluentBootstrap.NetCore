using System.ComponentModel;

namespace FluentBootstrapNCore.Links
{
    public enum LinkTarget
    {
        [Description("_blank")]
        Blank,
        [Description("_self")]
        Self,
        [Description("_parent")]
        Parent,
        [Description("_top")]
        Top
    }
}
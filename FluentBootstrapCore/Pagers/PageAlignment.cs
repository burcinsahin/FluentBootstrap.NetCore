using System.ComponentModel;

namespace FluentBootstrapNCore.Pagers
{
    public enum PageAlignment
    {
        [Description()]
        Default,
        [Description(Css.Previous)]
        Previous,
        [Description(Css.Next)]
        Next
    }
}

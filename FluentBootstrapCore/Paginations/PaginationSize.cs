using System.ComponentModel;

namespace FluentBootstrapCore
{
    public enum PaginationSize
    {
        [Description()]
        Default,
        [Description(Css.PaginationLg)]
        Lg,
        [Description(Css.PaginationSm)]
        Sm
    }
}

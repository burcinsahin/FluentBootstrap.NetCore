using System.ComponentModel;

namespace FluentBootstrapNCore.Paginations
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

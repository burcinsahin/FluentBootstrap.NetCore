using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Breadcrumbs
{
    public class Breadcrumb : Tag,
        ICanCreate<Crumb>
    {
        internal Breadcrumb(BootstrapHelper helper)
            : base(helper, "ol", Css.Breadcrumb)
        {
        }
    }
}

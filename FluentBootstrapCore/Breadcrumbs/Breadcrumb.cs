namespace FluentBootstrapCore.Breadcrumbs
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

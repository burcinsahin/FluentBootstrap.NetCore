namespace FluentBootstrapCore.Navs
{
    public class Tabs : Nav,
        ICanCreate<Tab>
    {
        internal Tabs(BootstrapHelper helper)
            : base(helper, Css.Nav, Css.NavTabs)
        {
            MergeAttribute("role", "tablist");
        }
    }
}

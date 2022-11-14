namespace FluentBootstrapCore.Navs
{
    public class Pills : Nav,
        ICanCreate<Pill>
    {
        internal Pills(BootstrapHelper helper)
            : base(helper, Css.Nav, Css.NavPills)
        {
        }
    }
}

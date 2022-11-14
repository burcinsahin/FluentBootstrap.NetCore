using FluentBootstrapCore.Dropdowns;

namespace FluentBootstrapCore.Navs
{
    public abstract class Nav : Tag,
        ICanCreate<Dropdown>
    {
        protected Nav(BootstrapHelper helper, params string[] cssClasses)
            : base(helper, "ul", cssClasses)
        {
        }
    }
}

using FluentBootstrapNCore.Dropdowns;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Navs
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

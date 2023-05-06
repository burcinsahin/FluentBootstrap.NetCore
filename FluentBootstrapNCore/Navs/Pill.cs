using FluentBootstrapNCore.Badges;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Navs
{
    public class Pill : NavLink,
        ICanCreate<Badge>
    {
        internal Pill(BootstrapHelper helper)
            : base(helper)
        {
        }
    }
}

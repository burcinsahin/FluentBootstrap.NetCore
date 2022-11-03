using FluentBootstrapCore.Badges;

namespace FluentBootstrapCore.Navs
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

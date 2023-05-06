using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Badges
{
    public class Badge : Tag, IHasTextContent
    {
        internal Badge(BootstrapHelper helper)
            : base(helper, "span", Css.Badge)
        {
        }
    }
}

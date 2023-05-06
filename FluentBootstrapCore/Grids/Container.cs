using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Grids
{
    public class Container : Tag,
        ICanCreate<GridRow>
    {
        internal Container(BootstrapHelper helper)
            : base(helper, "div", Css.Container)
        {
        }
    }
}

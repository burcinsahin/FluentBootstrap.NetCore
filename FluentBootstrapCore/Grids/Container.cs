namespace FluentBootstrapCore.Grids
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

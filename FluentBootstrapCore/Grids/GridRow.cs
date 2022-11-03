namespace FluentBootstrapCore.Grids
{
    public class GridRow : Tag,
        ICanCreate<GridColumn>
    {
        internal GridRow(BootstrapHelper helper)
            : base(helper, "div", Css.Row)
        {
        }
    }
}

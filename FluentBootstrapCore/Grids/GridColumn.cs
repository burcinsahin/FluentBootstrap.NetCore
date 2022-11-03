using FluentBootstrapCore.Thumbnails;

namespace FluentBootstrapCore.Grids
{
    public class GridColumn : Tag, IHasGridColumnExtensions,
        ICanCreate<Thumbnail>,
        ICanCreate<ThumbnailContainer>
    {
        internal GridColumn(BootstrapHelper helper)
            : base(helper, "div")
        {
        }
    }
}

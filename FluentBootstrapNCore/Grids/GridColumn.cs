using FluentBootstrapNCore.Interfaces;
using FluentBootstrapNCore.Thumbnails;

namespace FluentBootstrapNCore.Grids
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

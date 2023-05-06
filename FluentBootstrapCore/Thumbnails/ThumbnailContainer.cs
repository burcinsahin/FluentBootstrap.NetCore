using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Thumbnails
{
    public class ThumbnailContainer : Tag,
        ICanCreate<Thumbnail>,
        ICanCreate<Caption>
    {
        internal ThumbnailContainer(BootstrapHelper helper)
            : base(helper, "div", Css.Thumbnail)
        {
        }
    }
}

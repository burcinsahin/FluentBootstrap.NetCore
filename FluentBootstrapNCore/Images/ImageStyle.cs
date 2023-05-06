using System.ComponentModel;

namespace FluentBootstrapNCore.Images
{
    public enum ImageStyle
    {
        [Description()]
        Default,
        [Description(Css.ImgRounded)]
        Rounded,
        [Description(Css.ImgCircle)]
        Circle,
        [Description(Css.ImgThumbnail)]
        Thumbnail
    }
}

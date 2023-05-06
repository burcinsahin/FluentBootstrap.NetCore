using FluentBootstrapNCore.Images;
using FluentBootstrapNCore.Links;
using System.IO;

namespace FluentBootstrapNCore.Thumbnails
{
    public class Thumbnail : Tag, IHasLinkExtensions
    {
        private Image _image;
        private bool _suppressOuterTag;

        public string Src { get; set; }
        public string Alt { get; set; }

        internal Thumbnail(BootstrapHelper helper)
            : base(helper, "a", Css.Thumbnail)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            // Remove the thumbnail class if in a ThumbnailContainer
            var inContainer = false;
            if (GetComponent<ThumbnailContainer>(true) != null)
            {
                RemoveCss(Css.Thumbnail);
                inContainer = true;
            }

            // Change to a div if no link was provided (or don't output at all if in a container)
            var href = GetAttribute("href");
            if (string.IsNullOrWhiteSpace(href))
            {
                TagName = "div";
                if (inContainer)
                    _suppressOuterTag = true;
            }

            base.OnStart(_suppressOuterTag ? new SuppressOutputWriter() : writer);

            _image = GetHelper().Image(Src, Alt).Component;
            _image.Start(writer);
        }

        protected override void OnFinish(TextWriter writer)
        {
            _image.Finish(writer);

            base.OnFinish(_suppressOuterTag ? new SuppressOutputWriter() : writer);
        }
    }
}

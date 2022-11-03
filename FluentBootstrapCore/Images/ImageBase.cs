using FluentBootstrapCore.Links;

namespace FluentBootstrapCore.Images
{
    public abstract class ImageBase : Tag, IHasLinkExtensions
    {
        private Link _link;

        protected ImageBase(BootstrapHelper helper)
            : base(helper, "img")
        {
            OutputEndTag = false;
        }

        protected override void OnStart(System.IO.TextWriter writer)
        {
            string href = GetAttribute("href");
            if (!string.IsNullOrWhiteSpace(href))
            {
                PrettyPrint = false;
                MergeAttribute("href", null);
                _link = GetHelper().Link(null, href).Component;
                _link.Start(writer);
            }

            base.OnStart(writer);
        }

        protected override void OnFinish(System.IO.TextWriter writer)
        {
            base.OnFinish(writer);

            if (_link != null)
            {
                _link.Finish(writer);
            }
        }
    }
}

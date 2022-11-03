using FluentBootstrapCore.Icons;

namespace FluentBootstrapCore.Html
{
    public class Span : Tag, IHasTextContent, IHasIconExtensions, IHasTitleAttribute
    {
        internal Span(BootstrapHelper helper)
            : base(helper, "span")
        {
        }
    }
}

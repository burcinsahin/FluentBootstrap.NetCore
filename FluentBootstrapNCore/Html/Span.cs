using FluentBootstrapNCore.Icons;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Html
{
    public class Span : Tag, IHasTextContent, IHasIconExtensions, IHasTitleAttribute
    {
        internal Span(BootstrapHelper helper)
            : base(helper, "span")
        {
        }
    }
}

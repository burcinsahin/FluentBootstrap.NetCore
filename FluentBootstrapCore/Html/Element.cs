using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Html
{
    // Like Tag but implements IHasTextContent (we don't want all Tags to have text content)
    public class Element : Tag, IHasTextContent
    {
        internal Element(BootstrapHelper helper, string tagName)
            : base(helper, tagName)
        {
        }
    }
}

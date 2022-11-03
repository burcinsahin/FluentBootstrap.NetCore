using Microsoft.AspNetCore.Html;
using System.IO;
using System.Web;

namespace FluentBootstrapCore
{
    public class Content : Component
    {
        private readonly object _content;

        internal Content(BootstrapHelper helper, object content)
            : base(helper)
        {
            _content = content;
        }

        protected override void OnStart(TextWriter writer)
        {
            base.OnStart(writer);
            IHtmlContent? htmlString = _content as IHtmlContent;
            writer.Write(htmlString != null ? htmlString.ToString() : HttpUtility.HtmlEncode(_content));
        }
    }
}

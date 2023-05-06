using FluentBootstrapNCore.Interfaces;
using FluentBootstrapNCore.ListGroups;
using System.IO;

namespace FluentBootstrapNCore.Html
{
    public class Paragraph : Tag, IHasTextContent
    {
        internal Paragraph(BootstrapHelper helper)
            : base(helper, "p")
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            // Add the appropriate CSS class if in a list group item
            if (GetComponent<ListGroupItem>() != null)
                AddCss(Css.ListGroupItemText);

            base.OnStart(writer);
        }
    }
}

using FluentBootstrapNCore.Badges;
using FluentBootstrapNCore.Html;
using FluentBootstrapNCore.Interfaces;
using FluentBootstrapNCore.Links;
using FluentBootstrapNCore.Typography;
using System.IO;

namespace FluentBootstrapNCore.ListGroups
{
    public class ListGroupItem : Tag, IHasLinkExtensions, IHasTextContent,
        ICanCreate<Badge>,
        ICanCreate<Heading>,
        ICanCreate<Paragraph>
    {
        public bool Active { get; set; }
        public bool Disabled { get; set; }
        public string Heading { get; set; }

        internal ListGroupItem(BootstrapHelper helper)
            : base(helper, "a", Css.ListGroupItem)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            // Change to a div if no link was provided
            var href = GetAttribute("href");
            if (string.IsNullOrWhiteSpace(href))
                TagName = "div";

            if (Active)
                AddCss(Css.Active);
            if (Disabled)
                AddCss(Css.Disabled);

            // Cache the text content for after opening tag
            object textContent = null;
            if (!string.IsNullOrWhiteSpace(Heading))
            {
                textContent = TextContent;
                TextContent = null;
            }

            base.OnStart(writer);

            // Add the heading
            if (!string.IsNullOrWhiteSpace(Heading))
            {
                GetHelper().Heading4(Heading).Component.StartAndFinish(writer);

                // Put text in a paragraph, but only if there's also a heading
                if (textContent != null)
                    GetHelper().Paragraph(textContent).Component.StartAndFinish(writer);
            }

        }
    }
}

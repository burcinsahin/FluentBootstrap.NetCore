using FluentBootstrapNCore.Interfaces;
using FluentBootstrapNCore.Links;
using System;
using System.IO;

namespace FluentBootstrapNCore.Panels
{
    public class PanelTitle : Tag, IHasTextContent, ICanCreate<Link>
    {
        internal PanelTitle(BootstrapHelper helper, object text, int headingLevel)
            : base(helper, "h" + headingLevel, Css.PanelTitle)
        {
            if (headingLevel < 1 || headingLevel > 6)
                throw new ArgumentOutOfRangeException(nameof(headingLevel));
            TextContent = text;
        }

        protected override void OnStart(TextWriter writer)
        {
            // Make sure we're in a PanelHeading
            if (GetComponent<PanelHeading>() == null)
                GetHelper().PanelHeading().Component.Start(writer);

            var panel = GetComponent<Panel>();
            if (panel != null && panel.Collapsible)
            {
                var link = GetHelper()
                    .Link(TextContent, $"#{panel.Id}_collapse")
                    .AddAttribute("data-toggle", "collapse");

                var panelGroup = GetComponent<PanelGroup>();
                if (panelGroup != null && panelGroup.Accordion)
                    link.AddAttribute("data-parent", $"#{panelGroup.Id}");

                AddChild(link);
                TextContent = null;
            }

            base.OnStart(writer);
        }
    }
}
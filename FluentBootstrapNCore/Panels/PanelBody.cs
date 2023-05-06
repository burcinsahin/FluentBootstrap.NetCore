using FluentBootstrapNCore.Html;
using System.IO;

namespace FluentBootstrapNCore.Panels
{
    public class PanelBody : PanelSection
    {
        internal PanelBody(BootstrapHelper helper)
            : base(helper, Css.PanelBody)
        {
        }

        #region Overrides of PanelSection
        protected override void OnStart(TextWriter writer)
        {
            //var accordionPanelGroup = GetComponent<AccordionPanelGroup>();
            var panel = GetComponent<Panel>();
            if (panel.Collapsible)
            {
                var builder = GetHelper().Div()
                    .AddCss(Css.PanelCollapse, Css.Collapse)
                    .SetId($"{panel.Id}_collapse");
                if (panel.Expanded) builder.Component.AddCss(Css.In);

                builder.Component.Start(writer);
            }
            base.OnStart(writer);
        }
        #endregion
    }
}

using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Panels
{
    public class PanelHeading : PanelSection,
        ICanCreate<PanelTitle>
    {
        internal PanelHeading(BootstrapHelper helper)
            : base(helper, Css.PanelHeading)
        {
        }
    }
}

using FluentBootstrapNCore.Grids;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Forms
{
    public class ControlLabel : Tag, IHasGridColumnExtensions, IHasTextContent
    {
        internal ControlLabel(BootstrapHelper helper, object text)
            : base(helper, "label", Css.ControlLabel)
        {
            TextContent = text;
        }
    }
}

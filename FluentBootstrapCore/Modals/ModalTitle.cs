using System.IO;

namespace FluentBootstrapCore.Modals
{
    public class ModalTitle : Tag, IHasTextContent
    {
        public ModalTitle(BootstrapHelper helper, string text)
            : base(helper, "h4", Css.ModalTitle)
        {
            TextContent = text;
        }

        protected override void OnStart(TextWriter writer)
        {
            if (GetComponent<ModalHeading>() == null)
            {
                GetHelper().PanelHeading().Component.Start(writer);
            }

            base.OnStart(writer);
        }
    }
}
using System.IO;

namespace FluentBootstrapCore.Modals
{
    public class ModalHeading : ModalSection, ICanCreate<ModalTitle>
    {
        public ModalHeading(BootstrapHelper helper)
            : base(helper, Css.ModalHeader) { }

        protected override void OnStart(TextWriter writer)
        {
            base.OnStart(writer);
            writer.Write("<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>");
        }
    }
}
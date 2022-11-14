using FluentBootstrapCore.ListGroups;
using System.IO;

namespace FluentBootstrapCore.Modals
{
    public class Modal : Tag,
        ICanCreate<ModalSection>,
        ICanCreate<ModalTitle>,
        ICanCreate<ListGroup>
    {
        internal Modal(BootstrapHelper helper)
            : base(helper, "div", Css.Modal, Css.Fade) { }

        protected override void OnStart(TextWriter writer)
        {
            base.OnStart(writer);
            writer.Write(@"<div class=""modal-dialog"">");
            writer.Write(@"<div class=""modal-content"">");
        }

        protected override void OnFinish(TextWriter writer)
        {
            writer.Write(@"</div>");
            writer.Write(@"</div>");
            base.OnFinish(writer);
        }
    }
}

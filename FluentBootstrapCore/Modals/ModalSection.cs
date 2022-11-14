using System.IO;

namespace FluentBootstrapCore.Modals
{
    public class ModalSection : Tag
    {
        public ModalSection(BootstrapHelper helper, params string[] cssClasses)
            : base(helper, "div", cssClasses)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            Pop<ModalSection>(writer);

            base.OnStart(writer);
        }
    }
}
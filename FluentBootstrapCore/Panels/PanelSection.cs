using System.IO;

namespace FluentBootstrapCore.Panels
{
    public abstract class PanelSection : Tag
    {
        protected PanelSection(BootstrapHelper helper, params string[] cssClasses)
            : base(helper, "div", cssClasses)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            Pop<PanelSection>(writer);

            base.OnStart(writer);
        }
    }
}

using System.IO;

namespace FluentBootstrapNCore.Navbars
{
    public abstract class NavbarSection : Tag
    {
        protected NavbarSection(BootstrapHelper helper, string tagName, params string[] cssClasses)
            : base(helper, tagName, cssClasses)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            // Exit any existing navbar sections
            Pop<NavbarSection>(writer);

            base.OnStart(writer);
        }
    }
}

using FluentBootstrapNCore.Interfaces;
using System.IO;

namespace FluentBootstrapNCore.Navbars
{
    public class NavbarHeader : NavbarSection,
        ICanCreate<NavbarToggle>,
        ICanCreate<Brand>
    {
        public bool HasToggle { get; set; }

        internal NavbarHeader(BootstrapHelper helper)
            : base(helper, "div", Css.NavbarHeader)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            var navbar = GetComponent<Navbar>();
            if (navbar != null)
                navbar.HasHeader = true;

            base.OnStart(writer);
        }

        protected override void OnFinish(TextWriter writer)
        {
            if (!HasToggle)
                GetHelper().NavbarToggle().Component.StartAndFinish(writer);

            base.OnFinish(writer);
        }
    }
}

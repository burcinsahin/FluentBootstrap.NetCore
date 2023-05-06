using FluentBootstrapNCore.Dropdowns;
using FluentBootstrapNCore.Interfaces;
using System.IO;

namespace FluentBootstrapNCore.Navbars
{
    public class NavbarCollapse : NavbarSection,
        ICanCreate<NavbarNav>,
        ICanCreate<NavbarLink>,
        ICanCreate<Dropdown>,
        ICanCreate<NavbarForm>,
        ICanCreate<NavbarButton>,
        ICanCreate<NavbarText>
    {
        internal NavbarCollapse(BootstrapHelper helper)
            : base(helper, "div", Css.NavbarCollapse, Css.Collapse)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            // Get the Navbar ID and use it to set this id
            if (string.IsNullOrWhiteSpace(GetAttribute("id")))
            {
                var navbar = GetComponent<Navbar>();
                if (navbar != null)
                    GetBuilder(this).SetId(navbar.GetAttribute("id") + "-collapse");
            }

            base.OnStart(writer);
        }
    }
}

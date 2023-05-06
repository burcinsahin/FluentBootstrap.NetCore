using FluentBootstrapNCore.Alerts;
using FluentBootstrapNCore.Badges;
using FluentBootstrapNCore.Icons;
using FluentBootstrapNCore.Interfaces;
using FluentBootstrapNCore.Navbars;
using System.IO;

namespace FluentBootstrapNCore.Links
{
    public class Link : Tag, IHasIconExtensions, IHasLinkExtensions, IHasTextContent,
        ICanCreate<Badge>
    {
        internal Link(BootstrapHelper helper)
            : base(helper, "a")
        {
            PrettyPrint = false;
        }

        protected override void OnStart(TextWriter writer)
        {
            // Adjust the link style if we're in a navbar
            if (GetComponent<Navbar>() != null)
                CssClasses.Add(Css.NavbarLink);

            // Adjust the link style if we're in an alert
            if (GetComponent<Alert>() != null)
                CssClasses.Add(Css.AlertLink);

            base.OnStart(writer);
        }
    }
}

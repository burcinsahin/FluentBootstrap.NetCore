using FluentBootstrapCore.Html;
using FluentBootstrapCore.Links;
using System.IO;

namespace FluentBootstrapCore.Navbars
{
    public class NavbarLink : Tag, IHasLinkExtensions, IHasTextContent
    {
        private Element _listItem = null;

        public bool Active { get; set; }
        public bool Disabled { get; set; }

        internal NavbarLink(BootstrapHelper helper)
            : base(helper, "a")
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            // Check if we're in a navbar, and if so, make sure we're in a navbar nav
            if (GetComponent<Navbar>() != null && GetComponent<NavbarNav>() == null)
            {
                GetHelper().NavbarNav().Component.Start(writer);
            }

            // Create the list item wrapper
            _listItem = GetHelper().Element("li").Component;
            if (Active)
            {
                _listItem.AddCss(Css.Active);
            }
            if (Disabled)
            {
                _listItem.AddCss(Css.Disabled);
            }
            _listItem.Start(writer);

            base.OnStart(writer);
        }

        protected override void OnFinish(TextWriter writer)
        {
            base.OnFinish(writer);

            _listItem.Finish(writer);
        }
    }
}

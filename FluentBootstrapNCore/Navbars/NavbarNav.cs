﻿using FluentBootstrapNCore.Dropdowns;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Navbars
{
    public class NavbarNav : Tag, INavbarComponent,
        ICanCreate<NavbarLink>,
        ICanCreate<Dropdown>
    {
        internal NavbarNav(BootstrapHelper helper)
            : base(helper, "ul", Css.Nav, Css.NavbarNav, Css.NavbarLeft)
        {
        }

        protected override void OnStart(System.IO.TextWriter writer)
        {
            // Make sure we're in a collapse, but only if we're also in a navbar
            if (GetComponent<Navbar>() != null && GetComponent<NavbarCollapse>() == null)
                GetHelper().NavbarCollapse().Component.Start(writer);

            base.OnStart(writer);
        }
    }
}

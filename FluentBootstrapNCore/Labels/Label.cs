﻿using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Labels
{
    public class Label : Tag, IHasTextContent
    {
        internal Label(BootstrapHelper helper)
            : base(helper, "span", Css.Label, Css.LabelDefault)
        {
        }
    }
}

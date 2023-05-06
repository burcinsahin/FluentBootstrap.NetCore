﻿using FluentBootstrapNCore.Interfaces;
using System.IO;

namespace FluentBootstrapNCore.Forms
{
    public class Select : FormControl, IHasNameAttribute,
        ICanCreate<SelectOption>
    {
        public bool Multiple { get; set; }

        // This is needed so that when adding options, we can check if they match the model value and select if so
        public string ModelValue { get; set; }

        internal Select(BootstrapHelper helper)
            : base(helper, "select", Css.FormControl)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            if (Multiple)
                MergeAttribute("multiple", "multiple");

            base.OnStart(writer);
        }
    }
}

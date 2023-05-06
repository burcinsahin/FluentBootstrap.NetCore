﻿using FluentBootstrapNCore.Dropdowns;
using FluentBootstrapNCore.Html;
using FluentBootstrapNCore.Icons;
using FluentBootstrapNCore.Interfaces;
using FluentBootstrapNCore.Misc;

namespace FluentBootstrapNCore.Buttons
{
    public class ButtonDropdown : Tag, IHasIconExtensions, IHasButtonExtensions, IHasButtonStateExtensions, IHasTextContent,
        ICanCreate<DropdownDivider>,
        ICanCreate<DropdownHeader>,
        ICanCreate<DropdownLink>
    {
        private ButtonGroup _buttonGroup = null;
        public bool Split { get; set; }
        public bool Dropup { get; set; }

        internal ButtonDropdown(BootstrapHelper helper)
            : base(helper, "ul")
        {
        }

        protected override void OnStart(System.IO.TextWriter writer)
        {
            // Add the outer group
            _buttonGroup = GetHelper().ButtonGroup().Component;
            if (Dropup)
                _buttonGroup.AddCss(Css.Dropup);
            _buttonGroup.Start(writer);

            // Add the action button if split and copy over button CSS classes
            // Also move the icon to the button (if one is present)
            // But only create the split if we actually have some text to put in it
            if (Split && TextContent != null)
            {
                var button = GetHelper().Button(TextContent).Component;
                MoveIcons(button);
                TextContent = null;
                foreach (var cssClass in CssClasses)
                {
                    button.CssClasses.Add(cssClass);
                }
                button.MergeAttributes(Attributes.Dictionary);
                Attributes.Dictionary.Clear();
                button.StartAndFinish(writer);
            }

            // Create the dropdown button, copy over CSS, add the text and caret, then render
            var dropdown = GetHelper().Button(buttonType: ButtonType.Button).Component;
            MoveIcons(dropdown);
            dropdown.AddCss(Css.Btn, Css.BtnDefault, Css.DropdownToggle);
            dropdown.MergeAttribute("data-toggle", "dropdown");
            foreach (var cssClass in CssClasses)
            {
                dropdown.CssClasses.Add(cssClass);
            }
            dropdown.MergeAttributes(Attributes.Dictionary);
            Attributes.Dictionary.Clear();
            CssClasses.Clear();
            if (TextContent != null)
            {
                dropdown.AddChild(GetHelper().Content(TextContent));
                dropdown.AddChild(GetHelper().Content(" "));
            }
            else
            {
                var element = GetHelper().Element("span").AddCss(Css.SrOnly).Component;
                element.AddChild(GetHelper().Content("Toggle Dropdown"));
                dropdown.AddChild(element);
            }
            dropdown.AddChild(GetHelper().Caret());
            TextContent = null;
            dropdown.StartAndFinish(writer);

            // Add CSS and attributes after we've copied all the user-specified stuff to the buttons
            MergeAttribute("role", "menu");
            AddCss(Css.DropdownMenu);

            base.OnStart(writer);
        }

        private void MoveIcons(Button button)
        {
            var icon = Children.FindIndex(x => x is IconSpan);
            while (icon != -1)
            {
                button.AddChild(Children[icon]);
                button.AddChild(Children[icon + 1]); // Don't forget the extra space
                Children.RemoveAt(icon + 1);
                Children.RemoveAt(icon);
                icon = Children.FindIndex(x => x is IconSpan);
            }
        }

        protected override void OnFinish(System.IO.TextWriter writer)
        {
            base.OnFinish(writer);
            _buttonGroup.Finish(writer);
        }
    }
}

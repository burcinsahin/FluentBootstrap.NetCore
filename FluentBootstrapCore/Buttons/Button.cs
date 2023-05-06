using FluentBootstrapNCore.Badges;
using FluentBootstrapNCore.Icons;
using FluentBootstrapNCore.Interfaces;
using System.IO;

namespace FluentBootstrapNCore.Buttons
{
    public class Button : Tag,
        IHasIconExtensions, IHasButtonExtensions, IHasButtonStateExtensions,
        IHasDisabledAttribute, IHasTextContent, IHasValueAttribute, IHasNameAttribute,
        ICanCreate<Badge>
    {
        private ButtonGroup _buttonGroup;

        internal Button(BootstrapHelper helper, ButtonType buttonType)
            : base(helper, "button", Css.Btn, Css.BtnDefault)
        {
            MergeAttribute("type", buttonType.GetDescription());
        }

        protected override void OnStart(TextWriter writer)
        {
            // Fix for justified buttons in a group (need to surround them with an extra button group)
            // See https://github.com/twbs/bootstrap/issues/12476
            var buttonGroup = GetComponent<ButtonGroup>(true);
            if (buttonGroup != null && buttonGroup.CssClasses.Contains(Css.BtnGroupJustified))
            {
                _buttonGroup = GetHelper().ButtonGroup().Component;
                _buttonGroup.Start(writer);
            }

            base.OnStart(writer);
        }

        protected override void OnFinish(TextWriter writer)
        {
            base.OnFinish(writer);

            if (_buttonGroup != null)
                _buttonGroup.Finish(writer);
        }
    }
}

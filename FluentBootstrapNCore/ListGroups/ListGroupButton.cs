using FluentBootstrapNCore.Badges;
using FluentBootstrapNCore.Icons;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.ListGroups
{
    public class ListGroupButton : Tag, IHasIconExtensions, IHasDisabledAttribute, IHasTextContent, IHasValueAttribute,
        ICanCreate<Badge>
    {
        internal ListGroupButton(BootstrapHelper helper)
            : base(helper, "button", Css.ListGroupItem)
        {
            MergeAttribute("type", "button");
        }
    }
}

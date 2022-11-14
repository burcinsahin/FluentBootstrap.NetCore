using FluentBootstrapCore.Badges;
using FluentBootstrapCore.Icons;

namespace FluentBootstrapCore.ListGroups
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

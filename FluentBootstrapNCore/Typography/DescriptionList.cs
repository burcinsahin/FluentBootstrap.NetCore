using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Typography
{
    public class DescriptionList : Tag,
        ICanCreate<Description>,
        ICanCreate<DescriptionTerm>
    {
        internal DescriptionList(BootstrapHelper helper)
            : base(helper, "dl")
        {
        }
    }
}

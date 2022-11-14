namespace FluentBootstrapCore.Typography
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

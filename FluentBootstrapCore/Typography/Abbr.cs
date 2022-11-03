namespace FluentBootstrapCore.Typography
{
    public class Abbr : Tag, IHasTextContent, IHasTitleAttribute
    {
        internal Abbr(BootstrapHelper helper)
            : base(helper, "abbr")
        {
        }
    }
}

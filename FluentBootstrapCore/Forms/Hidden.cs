namespace FluentBootstrapCore.Forms
{
    public class Hidden : Tag, IHasValueAttribute
    {
        internal Hidden(BootstrapHelper helper)
            : base(helper, "input")
        {
            MergeAttribute("type", "hidden");
        }
    }
}

namespace FluentBootstrapNCore.Wells
{
    public class Well : Tag
    {
        internal Well(BootstrapHelper helper)
            : base(helper, "div", Css.Well)
        {
        }
    }
}

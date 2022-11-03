namespace FluentBootstrapCore.Forms
{
    public class TextArea : FormControl, IHasNameAttribute, IHasMaxLengthAttribute
    {
        internal TextArea(BootstrapHelper helper)
            : base(helper, "textarea", Css.FormControl)
        {
        }
    }
}

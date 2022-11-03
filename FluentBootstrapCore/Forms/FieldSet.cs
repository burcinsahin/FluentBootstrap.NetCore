namespace FluentBootstrapCore.Forms
{
    public class FieldSet : Tag, IHasDisabledAttribute,
        ICanCreate<FormGroup>,
        ICanCreate<ControlLabel>,
        ICanCreate<FormControl>,
        ICanCreate<HelpBlock>
    {
        internal FieldSet(BootstrapHelper helper)
            : base(helper, "fieldset")
        {
        }
    }
}

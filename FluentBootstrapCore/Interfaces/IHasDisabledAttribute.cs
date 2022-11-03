namespace FluentBootstrapCore
{
    public interface IHasDisabledAttribute
    {
    }

    public static class DisabledAttributeExtensions
    {
        public static ComponentBuilder<TConfig, TTag> IsDisabled<TConfig, TTag>(this ComponentBuilder<TConfig, TTag> builder, bool disabled = true)
            where TConfig : BootstrapConfig
            where TTag : Tag, IHasDisabledAttribute
        {
            builder.Component.MergeAttribute("disabled", disabled ? "disabled" : null);
            return builder;
        }
    }
}

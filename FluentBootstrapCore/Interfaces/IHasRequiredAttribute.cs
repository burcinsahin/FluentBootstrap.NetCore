namespace FluentBootstrapCore
{
    public interface IHasRequiredAttribute
    {
    }

    public static class RequiredAttributeExtensions
    {
        public static ComponentBuilder<TConfig, TTag> IsRequired<TConfig, TTag>(this ComponentBuilder<TConfig, TTag> builder, bool required = true)
            where TConfig : BootstrapConfig
            where TTag : Tag, IHasRequiredAttribute
        {
            builder.Component.MergeAttribute("required", required ? "required" : null);
            return builder;
        }
    }
}
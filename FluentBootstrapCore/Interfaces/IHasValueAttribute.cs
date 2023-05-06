namespace FluentBootstrapNCore.Interfaces
{
    public interface IHasValueAttribute
    {
    }

    public static class ValueAttributeExtensions
    {
        public static ComponentBuilder<TConfig, TTag> SetValue<TConfig, TTag>(this ComponentBuilder<TConfig, TTag> builder, object value, string format = null)
            where TConfig : BootstrapConfig
            where TTag : Tag, IHasValueAttribute
        {
            builder.Component.MergeAttribute("value", value == null ? null : builder.Config.FormatValue(value, format));
            return builder;
        }
    }
}

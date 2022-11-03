namespace FluentBootstrapCore
{
    public interface IHasMaxLengthAttribute
    {
    }

    public static class MaxLengthAttributeExtensions
    {
        public static ComponentBuilder<TConfig, TTag> SetMaxLength<TConfig, TTag>(this ComponentBuilder<TConfig, TTag> builder, int value = 100)
            where TConfig : BootstrapConfig
            where TTag : Tag, IHasDisabledAttribute
        {
            if (value > 0)
                builder.Component.MergeAttribute("maxlength", value.ToString());
            return builder;
        }
    }
}
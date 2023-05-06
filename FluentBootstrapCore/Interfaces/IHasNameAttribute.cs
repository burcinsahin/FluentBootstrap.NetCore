namespace FluentBootstrapNCore.Interfaces
{
    public interface IHasNameAttribute
    {
    }

    public static class NameAttributeExtensions
    {
        public static ComponentBuilder<TConfig, TTag> SetName<TConfig, TTag>(this ComponentBuilder<TConfig, TTag> builder, string name)
            where TConfig : BootstrapConfig
            where TTag : Tag, IHasNameAttribute
        {
            builder.Component.MergeAttribute("name", name == null ? null : builder.Config.GetFullHtmlFieldName(name));
            return builder;
        }
    }
}

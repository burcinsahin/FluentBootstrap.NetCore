namespace FluentBootstrapNCore.Interfaces
{
    public interface IHasTextContent
    {
    }

    public static class TextContentExtensions
    {
        public static ComponentBuilder<TConfig, TTag> SetText<TConfig, TTag>(this ComponentBuilder<TConfig, TTag> builder, object text)
            where TConfig : BootstrapConfig
            where TTag : Tag, IHasTextContent
        {
            builder.Component.TextContent = text;
            return builder;
        }
    }
}

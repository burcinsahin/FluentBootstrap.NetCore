using FluentBootstrapNCore.Icons;
using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Html
{
    public static class HtmlExtensions
    {
        public static ComponentBuilder<TConfig, Element> Element<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, string name)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Tag>
        {
            return new ComponentBuilder<TConfig, Element>(helper.Config, new Element(helper, name));
        }

        public static ComponentBuilder<TConfig, Element> Div<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, object text = null)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Tag>
        {
            return new ComponentBuilder<TConfig, Element>(helper.Config, new Element(helper, "div")).SetText(text);
        }

        public static ComponentBuilder<TConfig, Span> Span<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, object text = null, Icon icon = Icon.None)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Span>
        {
            return new ComponentBuilder<TConfig, Span>(helper.Config, new Span(helper)).SetText(text).SetIcon(icon);
        }

        public static ComponentBuilder<TConfig, Paragraph> Paragraph<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, object text = null)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Paragraph>
        {
            return new ComponentBuilder<TConfig, Paragraph>(helper.Config, new Paragraph(helper)).SetText(text);
        }
    }
}

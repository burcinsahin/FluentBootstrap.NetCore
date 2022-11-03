using FluentBootstrapCore.Labels;

namespace FluentBootstrapCore
{
    public static class LabelExtensions
    {
        public static ComponentBuilder<TConfig, Label> Label<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, object text)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Label>
        {
            return new ComponentBuilder<TConfig, Label>(helper.Config, new Label(helper))
                .SetText(text);
        }

        public static ComponentBuilder<TConfig, Label> SetState<TConfig>(this ComponentBuilder<TConfig, Label> builder, LabelState state)
            where TConfig : BootstrapConfig
        {
            builder.Component.ToggleCss(state);
            return builder;
        }
    }
}

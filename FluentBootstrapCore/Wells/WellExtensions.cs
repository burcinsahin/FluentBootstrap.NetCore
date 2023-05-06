using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Wells
{
    public static class WellExtensions
    {
        public static ComponentBuilder<TConfig, Well> Well<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Well>
        {
            return new ComponentBuilder<TConfig, Well>(helper.Config, new Well(helper));
        }

        public static ComponentBuilder<TConfig, Well> SetSize<TConfig>(this ComponentBuilder<TConfig, Well> builder, WellSize size)
            where TConfig : BootstrapConfig
        {
            builder.Component.ToggleCss(size);
            return builder;
        }
    }
}

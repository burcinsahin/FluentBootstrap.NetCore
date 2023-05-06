using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Badges
{
    public static class BadgeExtensions
    {
        public static ComponentBuilder<TConfig, Badge> Badge<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, object text)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Badge>
        {
            return new ComponentBuilder<TConfig, Badge>(helper.Config, new Badge(helper)).SetText(text);
        }
    }
}

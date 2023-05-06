using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.ProgressBars
{
    public static class ProgressBarExtensions
    {
        public static ComponentBuilder<TConfig, Progress> Progress<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Progress>
        {
            return new ComponentBuilder<TConfig, Progress>(helper.Config, new Progress(helper));
        }

        public static ComponentBuilder<TConfig, ProgressBar> ProgressBar<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, int value, int min = 0, int max = 100)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<ProgressBar>
        {
            return new ComponentBuilder<TConfig, ProgressBar>(helper.Config, new ProgressBar(helper))
                .SetValue(value)
                .SetMin(min)
                .SetMax(max);
        }

        public static ComponentBuilder<TConfig, ProgressBar> SetMin<TConfig>(this ComponentBuilder<TConfig, ProgressBar> builder, int min)
            where TConfig : BootstrapConfig
        {
            builder.Component.Min = min;
            return builder;
        }

        public static ComponentBuilder<TConfig, ProgressBar> SetMax<TConfig>(this ComponentBuilder<TConfig, ProgressBar> builder, int max)
            where TConfig : BootstrapConfig
        {
            builder.Component.Max = max;
            return builder;
        }

        public static ComponentBuilder<TConfig, ProgressBar> SetValue<TConfig>(this ComponentBuilder<TConfig, ProgressBar> builder, int value)
            where TConfig : BootstrapConfig
        {
            builder.Component.Value = value;
            return builder;
        }

        public static ComponentBuilder<TConfig, ProgressBar> SetPercent<TConfig>(this ComponentBuilder<TConfig, ProgressBar> builder, int percent)
            where TConfig : BootstrapConfig
        {
            builder.Component.Min = 0;
            builder.Component.Max = 100;
            builder.Component.Value = percent;
            return builder;
        }

        public static ComponentBuilder<TConfig, ProgressBar> ShowPercent<TConfig>(this ComponentBuilder<TConfig, ProgressBar> builder, bool showPercent = true)
            where TConfig : BootstrapConfig
        {
            builder.Component.ShowPercent = showPercent;
            return builder;
        }

        public static ComponentBuilder<TConfig, ProgressBar> SetState<TConfig>(this ComponentBuilder<TConfig, ProgressBar> builder, ProgressBarState state)
            where TConfig : BootstrapConfig
        {
            builder.Component.ToggleCss(state);
            return builder;
        }

        public static ComponentBuilder<TConfig, ProgressBar> SetStriped<TConfig>(this ComponentBuilder<TConfig, ProgressBar> builder, bool striped = true)
            where TConfig : BootstrapConfig
        {
            builder.Component.ToggleCss(Css.ProgressBarStriped, striped);
            return builder;
        }

        public static ComponentBuilder<TConfig, ProgressBar> SetAnimated<TConfig>(this ComponentBuilder<TConfig, ProgressBar> builder, bool animated = true)
            where TConfig : BootstrapConfig
        {
            builder.Component.Animated = animated;
            return builder;
        }
    }
}

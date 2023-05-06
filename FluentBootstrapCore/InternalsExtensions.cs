using FluentBootstrapNCore.Interfaces;
using System.IO;

namespace FluentBootstrapNCore
{
    // This is a bit of a hack, but exposing internal members via extension methods in a separate namespace
    // was the only good way I could think of to allow extending libraries access without resorting to
    // InternalsVisibleTo and without also making those members visible to consuming applications
    public static class InternalsExtensions
    {
        public static TConfig GetConfig<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component
        {
            return helper.Config;
        }

        public static TComponent GetComponent<TConfig, TComponent>(this ComponentBuilder<TConfig, TComponent> builder)
            where TConfig : BootstrapConfig
            where TComponent : Component
        {
            return builder.Component;
        }

        public static TConfig GetConfig<TConfig, TComponent>(this ComponentBuilder<TConfig, TComponent> builder)
            where TConfig : BootstrapConfig
            where TComponent : Component
        {
            return builder.Config;
        }

        public static Component GetComponent(this ComponentBuilder builder)
        {
            return builder.GetComponent();
        }

        public static BootstrapHelper<TConfig, CanCreate> GetHelper<TConfig, TComponent>(this ComponentBuilder<TConfig, TComponent> builder)
            where TConfig : BootstrapConfig
            where TComponent : Component
        {
            return builder.GetHelper();
        }

        public static void Start(this Component component, TextWriter writer)
        {
            component.Start(writer);
        }

        public static void Finish(this Component component, TextWriter writer)
        {
            component.Start(writer);
        }

        public static void StartAndFinish(this Component component, TextWriter writer)
        {
            component.StartAndFinish(writer);
        }
    }
}

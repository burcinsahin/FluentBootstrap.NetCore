using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Modals
{
    public static class ModalExtensions
    {
        public static ComponentBuilder<TConfig, Modal> Modal<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, string title = null)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Modal>
        {
            var builder = new ComponentBuilder<TConfig, Modal>(helper.Config, new Modal(helper));
            if (!string.IsNullOrWhiteSpace(title))
                builder.AddChild(x => x.ModalHeading().AddChild(y => y.ModalTitle(title)));
            return builder;
        }

        public static ComponentBuilder<TConfig, ModalHeading> ModalHeading<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<ModalHeading>
        {
            return new ComponentBuilder<TConfig, ModalHeading>(helper.Config, new ModalHeading(helper));
        }

        public static ComponentBuilder<TConfig, ModalBody> ModalBody<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<ModalBody>
        {
            return new ComponentBuilder<TConfig, ModalBody>(helper.Config, new ModalBody(helper));
        }

        public static ComponentBuilder<TConfig, ModalFooter> ModalFooter<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<ModalFooter>
        {
            return new ComponentBuilder<TConfig, ModalFooter>(helper.Config, new ModalFooter(helper));
        }

        public static ComponentBuilder<TConfig, ModalTitle> ModalTitle<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, string text = null)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<ModalTitle>
        {
            return new ComponentBuilder<TConfig, ModalTitle>(helper.Config, new ModalTitle(helper, text));
        }
    }
}

using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.Panels
{
    public static class PanelExtensions
    {
        public static ComponentBuilder<TConfig, PanelGroup> PanelGroup<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, bool accordion = false)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<PanelGroup>
        {
            return new ComponentBuilder<TConfig, PanelGroup>(helper.Config, new PanelGroup(helper) { Accordion = accordion });
        }

        #region Panel
        public static ComponentBuilder<TConfig, Panel> Panel<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, string title = null, int titleHeadingLevel = 4)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Panel>
        {
            var builder = new ComponentBuilder<TConfig, Panel>(helper.Config, new Panel(helper));
            if (!string.IsNullOrWhiteSpace(title))
                builder.AddChild(x => x.PanelHeading().AddChild(y => y.PanelTitle(title, titleHeadingLevel)));
            return builder;
        }

        public static ComponentBuilder<TConfig, Panel> SetState<TConfig>(this ComponentBuilder<TConfig, Panel> builder, PanelState state)
            where TConfig : BootstrapConfig
        {
            builder.Component.ToggleCss(state);
            return builder;
        }

        public static ComponentBuilder<TConfig, Panel> SetExpanded<TConfig>(this ComponentBuilder<TConfig, Panel> builder)
            where TConfig : BootstrapConfig
        {
            builder.Component.Expanded = true;
            return builder;
        }

        /// <summary>
        /// Set collapsible panel initial state as expanded. Default state is colllapsed
        /// </summary>
        /// <typeparam name="TConfig"></typeparam>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static ComponentBuilder<TConfig, Panel> SetCollapsible<TConfig>(this ComponentBuilder<TConfig, Panel> builder)
            where TConfig : BootstrapConfig
        {
            builder.Component.Collapsible = true;
            return builder;
        }
        #endregion

        // Sections

        public static ComponentBuilder<TConfig, PanelHeading> PanelHeading<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<PanelHeading>
        {
            return new ComponentBuilder<TConfig, PanelHeading>(helper.Config, new PanelHeading(helper));
        }

        public static ComponentBuilder<TConfig, PanelBody> PanelBody<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<PanelBody>
        {
            return new ComponentBuilder<TConfig, PanelBody>(helper.Config, new PanelBody(helper));
        }

        public static ComponentBuilder<TConfig, PanelFooter> PanelFooter<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<PanelFooter>
        {
            return new ComponentBuilder<TConfig, PanelFooter>(helper.Config, new PanelFooter(helper));
        }

        public static ComponentBuilder<TConfig, PanelTable> PanelTable<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<PanelTable>
        {
            return new ComponentBuilder<TConfig, PanelTable>(helper.Config, new PanelTable(helper));
        }

        // PanelTitle

        public static ComponentBuilder<TConfig, PanelTitle> PanelTitle<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, string text = null, int headingLevel = 4)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<PanelTitle>
        {
            return new ComponentBuilder<TConfig, PanelTitle>(helper.Config, new PanelTitle(helper, text, headingLevel));
        }
    }
}

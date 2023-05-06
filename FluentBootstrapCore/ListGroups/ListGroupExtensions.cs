﻿using FluentBootstrapNCore.Interfaces;
using FluentBootstrapNCore.Links;

namespace FluentBootstrapNCore.ListGroups
{
    public static class ListGroupExtensions
    {
        // ListGroup

        public static ComponentBuilder<TConfig, ListGroup> ListGroup<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<ListGroup>
        {
            return new ComponentBuilder<TConfig, ListGroup>(helper.Config, new ListGroup(helper));
        }

        // ListGroupItem

        public static ComponentBuilder<TConfig, ListGroupItem> ListGroupItem<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, object text = null, string href = null)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<ListGroupItem>
        {
            return new ComponentBuilder<TConfig, ListGroupItem>(helper.Config, new ListGroupItem(helper))
                .SetText(text)
                .SetHref(href);
        }

        public static ComponentBuilder<TConfig, ListGroupItem> SetActive<TConfig>(this ComponentBuilder<TConfig, ListGroupItem> builder, bool active = true)
            where TConfig : BootstrapConfig
        {
            builder.Component.Active = active;
            return builder;
        }

        public static ComponentBuilder<TConfig, ListGroupItem> SetDisabled<TConfig>(this ComponentBuilder<TConfig, ListGroupItem> builder, bool disabled = true)
            where TConfig : BootstrapConfig
        {
            builder.Component.Disabled = disabled;
            return builder;
        }

        public static ComponentBuilder<TConfig, ListGroupItem> SetHeading<TConfig>(this ComponentBuilder<TConfig, ListGroupItem> builder, string heading)
            where TConfig : BootstrapConfig
        {
            builder.Component.Heading = heading;
            return builder;
        }

        public static ComponentBuilder<TConfig, ListGroupItem> SetState<TConfig>(this ComponentBuilder<TConfig, ListGroupItem> builder, ListGroupItemState state)
            where TConfig : BootstrapConfig
        {
            builder.Component.ToggleCss(state);
            return builder;
        }

        // ListGroupButton

        public static ComponentBuilder<TConfig, ListGroupButton> ListGroupButton<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, object text = null, object value = null)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<ListGroupButton>
        {
            return new ComponentBuilder<TConfig, ListGroupButton>(helper.Config, new ListGroupButton(helper))
                .SetText(text)
                .SetValue(value);
        }
    }
}

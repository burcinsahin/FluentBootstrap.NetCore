﻿using FluentBootstrapCore.Paginations;
using System.Collections.Generic;
using System.Linq;

namespace FluentBootstrapCore
{
    public static class PaginationExtensions
    {
        // Pagination

        public static ComponentBuilder<TConfig, Pagination> Pagination<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Pagination>
        {
            return new ComponentBuilder<TConfig, Pagination>(helper.Config, new Pagination(helper));
        }

        public static ComponentBuilder<TConfig, Pagination> Pagination<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, IEnumerable<string> hrefs, int? activePageNumber = null, int? firstPageNumber = null)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Pagination>
        {
            return new ComponentBuilder<TConfig, Pagination>(helper.Config, new Pagination(helper))
                .AddPages(hrefs, activePageNumber, firstPageNumber);
        }

        public static ComponentBuilder<TConfig, Pagination> Pagination<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, IEnumerable<KeyValuePair<string, string>> textAndHrefs, int? activePageNumber = null, int? firstPageNumber = null)
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<Pagination>
        {
            return new ComponentBuilder<TConfig, Pagination>(helper.Config, new Pagination(helper))
                .AddPages(textAndHrefs, activePageNumber, firstPageNumber);
        }

        public static ComponentBuilder<TConfig, Pagination> SetSize<TConfig>(this ComponentBuilder<TConfig, Pagination> builder, PaginationSize size)
            where TConfig : BootstrapConfig
        {
            builder.Component.ToggleCss(size);
            return builder;
        }

        public static ComponentBuilder<TConfig, Pagination> AddPrevious<TConfig>(this ComponentBuilder<TConfig, Pagination> builder, string href = "#", bool active = false, bool disabled = false)
            where TConfig : BootstrapConfig
        {
            builder.AddChild(x => x.PageNum("«", href).SetActive(active).SetDisabled(disabled));
            return builder;
        }

        public static ComponentBuilder<TConfig, Pagination> AddNext<TConfig>(this ComponentBuilder<TConfig, Pagination> builder, string href = "#", bool active = false, bool disabled = false)
            where TConfig : BootstrapConfig
        {
            builder.AddChild(x => x.PageNum("»", href).SetActive(active).SetDisabled(disabled));
            return builder;
        }

        public static ComponentBuilder<TConfig, Pagination> AddPage<TConfig>(this ComponentBuilder<TConfig, Pagination> builder, string href = "#", bool active = false, bool disabled = false)
            where TConfig : BootstrapConfig
        {
            builder.AddChild(x => x.PageNum((++builder.Component.AutoPageNumber).ToString(), href).SetActive(active).SetDisabled(disabled));
            return builder;
        }

        public static ComponentBuilder<TConfig, Pagination> AddPages<TConfig>(this ComponentBuilder<TConfig, Pagination> builder, IEnumerable<string> hrefs, int? activePageNumber = null, int? firstPageNumber = null)
            where TConfig : BootstrapConfig
        {
            return builder.AddPages(hrefs.Select(x => new KeyValuePair<string, string>(null, x)), activePageNumber, firstPageNumber);
        }

        public static ComponentBuilder<TConfig, Pagination> AddPages<TConfig>(this ComponentBuilder<TConfig, Pagination> builder, IEnumerable<KeyValuePair<string, string>> textAndHrefs, int? activePageNumber = null, int? firstPageNumber = null)
            where TConfig : BootstrapConfig
        {
            if (firstPageNumber.HasValue)
            {
                builder.Component.AutoPageNumber = firstPageNumber.Value - 1;
            }
            foreach (KeyValuePair<string, string> textAndHref in textAndHrefs)
            {
                KeyValuePair<string, string> localTextAndHref = textAndHref;  // avoid access in closure
                builder.Component.AutoPageNumber++;
                builder.AddChild(x => x.PageNum(localTextAndHref.Key ?? builder.Component.AutoPageNumber.ToString(), localTextAndHref.Value)
                    .SetActive(builder.Component.AutoPageNumber == activePageNumber)
                    .SetDisabled(localTextAndHref.Value == null));
            }
            return builder;
        }

        // PageNum

        public static ComponentBuilder<TConfig, PageNum> PageNum<TConfig, TComponent>(this BootstrapHelper<TConfig, TComponent> helper, object text, string href = "#")
            where TConfig : BootstrapConfig
            where TComponent : Component, ICanCreate<PageNum>
        {
            return new ComponentBuilder<TConfig, PageNum>(helper.Config, new PageNum(helper))
                .SetHref(href)
                .SetText(text);
        }

        public static ComponentBuilder<TConfig, PageNum> SetActive<TConfig>(this ComponentBuilder<TConfig, PageNum> builder, bool active = true)
            where TConfig : BootstrapConfig
        {
            builder.Component.Active = active;
            return builder;
        }

        public static ComponentBuilder<TConfig, PageNum> SetDisabled<TConfig>(this ComponentBuilder<TConfig, PageNum> builder, bool disabled = true)
            where TConfig : BootstrapConfig
        {
            builder.Component.Disabled = disabled;
            return builder;
        }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace FluentBootstrapNCore.Mvc
{
    public class MvcBootstrapConfig<TModel> : BootstrapConfig
    {
        internal IHtmlHelper<TModel> HtmlHelper { get; private set; }

        public MvcBootstrapConfig(IHtmlHelper<TModel> htmlHelper)
        {
            HtmlHelper = htmlHelper;
        }

        protected override void RegisterComponentOverrides()
        {
            //RegisterComponentOverride<Form, FormOverride<TModel>>();
            //RegisterComponentOverride<FormControl, FormControlOverride<TModel>>();
        }

        protected override string GetFullHtmlFieldName(string name)
        {
            return HtmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
        }

        protected override TextWriter GetWriter()
        {
            return HtmlHelper.ViewContext.Writer;
        }

        protected override object GetItem(object key, object defaultValue)
        {
            if (HtmlHelper.ViewContext.HttpContext.Items.ContainsKey(key))
                return HtmlHelper.ViewContext.HttpContext.Items[key];
            return defaultValue;
        }

        protected override void AddItem(object key, object value)
        {
            HtmlHelper.ViewContext.HttpContext.Items[key] = value;
        }

    }
}

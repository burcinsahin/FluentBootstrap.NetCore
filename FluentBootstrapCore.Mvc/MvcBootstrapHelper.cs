using Microsoft.AspNetCore.Mvc.Rendering;

namespace FluentBootstrapCore.Mvc
{
    public class MvcBootstrapHelper<TModel> : BootstrapHelper<MvcBootstrapConfig<TModel>, CanCreate>
    {
        public MvcBootstrapHelper(IHtmlHelper<TModel> htmlHelper)
            : base(new MvcBootstrapConfig<TModel>(htmlHelper))
        {
        }
    }
}

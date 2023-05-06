using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Linq.Expressions;

namespace FluentBootstrapNCore.Mvc.Forms
{
    public class HiddenFor<TModel, TValue> : Component
    {
        private readonly Expression<Func<TModel, TValue>> _expression;

        internal HiddenFor(BootstrapHelper helper, Expression<Func<TModel, TValue>> expression)
            : base(helper)
        {
            _expression = expression;
        }

        protected override void OnStart(TextWriter writer)
        {
            base.OnStart(writer);
            writer.Write(this.GetHtmlHelper<TModel>().HiddenFor(_expression));
        }
    }
}

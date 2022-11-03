using System;
using System.Linq.Expressions;

namespace FluentBootstrapCore.Mvc.Forms
{
    public class FormControlFor<TModel, TValue> : FormControlForBase<TModel, TValue>
    {
        public FormControlFor(BootstrapHelper helper, bool editor, Expression<Func<TModel, TValue>> expression)
            : base(helper, editor, expression)
        {
        }
    }
}

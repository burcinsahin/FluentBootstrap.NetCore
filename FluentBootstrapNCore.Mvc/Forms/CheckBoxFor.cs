using FluentBootstrapNCore.Forms;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using System;
using System.IO;
using System.Linq.Expressions;

namespace FluentBootstrapNCore.Mvc.Forms
{
    public class CheckBoxFor<TModel, TValue> : Component
    {
        private readonly Expression<Func<TModel, TValue>> _expression;
        private readonly bool _isNameInLabel;
        private string _name;

        internal CheckBoxFor(BootstrapHelper helper, Expression<Func<TModel, TValue>> expression, bool isNameInLabel = true)
            : base(helper)
        {
            _expression = expression;
            _isNameInLabel = isNameInLabel;
        }

        protected override void OnStart(TextWriter writer)
        {
            base.OnStart(writer);
            var metadata = ExpressionMetadataProvider.FromLambdaExpression(_expression, this.GetHtmlHelper<TModel>().ViewData, this.GetHtmlHelper<TModel>().MetadataProvider);
            //ModelMetadata metadata = ModelMetadata.FromLambdaExpression(_expression, this.GetHtmlHelper<TModel>().ViewData);
            var expressionText = ExpressionHelper.GetExpressionText(_expression);
            _name = MvcFormExtensions.GetControlName(this.GetHelper<TModel>(), expressionText);
            var label = MvcFormExtensions.GetControlLabel(metadata.Metadata, expressionText);
            var isChecked = false;
            if (metadata.Model == null || !bool.TryParse(metadata.Model.ToString(), out isChecked))
                isChecked = false;
            writer.Write(_isNameInLabel
                ? GetHelper().CheckBox(_name, label, null, isChecked).AddAttribute("value", isChecked)
                : GetHelper().CheckBox(_name, null, label, isChecked).AddAttribute("value", isChecked));
        }

        protected override void OnFinish(TextWriter writer)
        {
            writer.Write(GetHelper().Hidden(_name, false));
            base.OnFinish(writer);
        }
    }
}
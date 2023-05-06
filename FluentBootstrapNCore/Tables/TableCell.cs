namespace FluentBootstrapNCore.Tables
{
    public abstract class TableCell : Tag, IHasTableStateExtensions
    {
        protected TableCell(BootstrapHelper helper, string tagName, params string[] cssClasses)
            : base(helper, tagName, cssClasses)
        {
        }
    }
}

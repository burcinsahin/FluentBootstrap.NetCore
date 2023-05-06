using FluentBootstrapNCore.Interfaces;
using System.IO;

namespace FluentBootstrapNCore.Tables
{
    public class TableRow : Tag, IHasTableStateExtensions,
        ICanCreate<TableCell>
    {
        internal bool HeadRow { get; set; }

        internal TableRow(BootstrapHelper helper)
            : base(helper, "tr")
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            Pop<TableRow>(writer);

            // Make sure we're in a section, but only if we're also in a table
            if (GetComponent<Table>() != null)
            {
                var tableSection = GetComponent<TableSection>();
                if (HeadRow)
                {
                    if (tableSection != null && !(tableSection is TableHeadSection) && tableSection.Implicit)
                    {
                        Pop(tableSection, writer);
                        tableSection = null;
                    }
                    if (tableSection == null)
                        GetHelper().TableHeadSection().Component.Start(writer);
                }
                else
                {
                    if (tableSection != null && !(tableSection is TableBodySection) && tableSection.Implicit)
                    {
                        Pop(tableSection, writer);
                        tableSection = null;
                    }
                    if (tableSection == null)
                        GetHelper().TableBodySection().Component.Start(writer);
                }
            }

            base.OnStart(writer);
        }
    }
}
using FluentBootstrapNCore.Html;
using FluentBootstrapNCore.Interfaces;
using System.IO;

namespace FluentBootstrapNCore.Pagers
{
    public class Pager : Tag,
        ICanCreate<Page>
    {
        private Element _nav = null;

        internal Pager(BootstrapHelper helper)
            : base(helper, "ul", Css.Pager)
        {
        }

        protected override void OnStart(TextWriter writer)
        {
            _nav = GetHelper().Element("nav").Component;
            _nav.Start(writer);

            base.OnStart(writer);
        }

        protected override void OnFinish(TextWriter writer)
        {
            base.OnFinish(writer);

            _nav.Finish(writer);
        }
    }
}

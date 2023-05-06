using FluentBootstrapNCore.Html;
using FluentBootstrapNCore.Interfaces;
using System.IO;

namespace FluentBootstrapNCore.Paginations
{
    public class Pagination : Tag,
        ICanCreate<PageNum>
    {
        private Element _nav = null;

        public int AutoPageNumber { get; set; }

        internal Pagination(BootstrapHelper helper)
            : base(helper, "ul", Css.Pagination)
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

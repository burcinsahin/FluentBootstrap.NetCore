using FluentBootstrapNCore.Interfaces;

namespace FluentBootstrapNCore.ProgressBars
{
    public class Progress : Tag,
        ICanCreate<ProgressBar>
    {
        internal Progress(BootstrapHelper helper)
            : base(helper, "div", Css.Progress)
        {
        }
    }
}

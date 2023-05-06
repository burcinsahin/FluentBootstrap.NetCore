using Microsoft.AspNetCore.Mvc;

namespace FluentBootstrapNCore.Tests.Mvc.Controllers
{
    public class TestsController : Controller
    {
        public virtual ActionResult Tests(string view)
        {
            return View(view);
        }
    }
}
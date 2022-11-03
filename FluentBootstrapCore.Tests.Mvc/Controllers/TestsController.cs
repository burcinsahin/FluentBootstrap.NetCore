using Microsoft.AspNetCore.Mvc;

namespace FluentBootstrap.Tests.Web.Controllers
{
    public class TestsController : Controller
    {
        public virtual ActionResult Tests(string view)
        {
            return View(view);
        }
    }
}
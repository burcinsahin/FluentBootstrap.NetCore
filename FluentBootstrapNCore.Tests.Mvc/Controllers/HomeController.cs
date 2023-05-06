using Microsoft.AspNetCore.Mvc;

namespace FluentBootstrapNCore.Tests.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public virtual IActionResult Index()
        {
            return View();
        }
    }
}
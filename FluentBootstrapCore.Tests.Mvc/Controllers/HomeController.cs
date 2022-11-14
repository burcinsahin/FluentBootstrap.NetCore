using Microsoft.AspNetCore.Mvc;

namespace FluentBootstrapCore.Tests.Web.Controllers
{
    public class HomeController : Controller
    {
        public virtual IActionResult Index()
        {
            return View();
        }
    }
}
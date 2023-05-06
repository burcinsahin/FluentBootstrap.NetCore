using FluentBootstrapNCore.Tests.Mvc.Models.MvcTests;
using Microsoft.AspNetCore.Mvc;

namespace FluentBootstrapNCore.Tests.Mvc.Controllers
{
    public class MvcTestsController : Controller
    {
        public virtual ActionResult MvcTests(string view)
        {
            var model = new ViewModel
            {
                PropA = "A",
                PropB = 2,
                PropC = "Two",
                PropCOptions = new Dictionary<int, string>()
                {
                    { 1, "One"},
                    { 2, "Two"},
                    { 3, "Three"}
                },
                PropD = true,
                Child = new ChildModel()
                {
                    ChildPropA = "Child A"
                }
            };
            ModelState.AddModelError(string.Empty, "General error message.");
            ModelState.AddModelError("PropB", "Property B error message.");
            return View(view, model);
        }
    }
}
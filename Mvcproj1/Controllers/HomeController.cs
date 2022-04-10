using Microsoft.AspNetCore.Mvc;
using Mvcproj1.Models;

namespace MvcMovie.Controllers
{
    public class HomeControllerName : Controller
    {
        [HttpGet, Route("Home/Index"), Route("")]
        public IActionResult Index()
        {
            Name name = new Name();
            return View("~/Views/emoH/Index.cshtml", name);
        }

        [HttpPost]
        public IActionResult Welcome(Name name1)
        {
            return View("~/Views/emoH/Welcome.cshtml", name1);
        }
    }
}
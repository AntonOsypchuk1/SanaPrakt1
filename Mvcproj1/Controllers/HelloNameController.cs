using Microsoft.AspNetCore.Mvc;
using Mvcproj1.Models;

namespace MvcMovie.Controllers
{
    public class HelloNameController : Controller
    {
        // 
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            Name name = new Name("");
            return View(name);
        }
        public ActionResult Welcome(string FirstName)
        {
            Name name = new Name(FirstName);
            return View(name);
        }
    }
}
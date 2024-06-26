using Elfie.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace TestWebSite.Controllers
{
    public class HSRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Physical()
        {
            return View(Physical); 
        }
        public IActionResult Fire()
        {
            return View();
        }
        public IActionResult Lightning()
        {
            return View();
        }
        public IActionResult Ice()
        {
            return View();
        }
        public IActionResult Wind()
        {
            return View();
        }
        public IActionResult Quantum()
        {
            return View();
        }
        public IActionResult Imaginary()
        {
            return View();
        }
        public IActionResult Hanya()
        {
            return View();
        }
    }
}

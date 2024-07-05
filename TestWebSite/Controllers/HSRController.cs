using Elfie.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using TestWebSite.Models;

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
            return View(); 
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
        public IActionResult Argenti()
        {
            return View();
        }
        public IActionResult Luka()
        {
            return View();
        }
        public IActionResult Sushang()
        {
            return View();
        }
        public IActionResult Clara()
        {
            return View();
        }
        public IActionResult Natasha()
        {
            return View();
        }
        public IActionResult PhysicalMC()
        {
            return View();
        }
        public IActionResult Boothill()
        {
            return View();
        }
        public IActionResult Robin()
        {
            return View();
        }
        public IActionResult Firefly()
        {
            return View();
        }
        public IActionResult Gallagher()
        {
            return View();
        }
        public IActionResult Topaz()
        {
            return View();
        }
        public IActionResult Guinaifen()
        {
            return View();
        }
        public IActionResult Hook()
        {
            return View();
        }
        public IActionResult Asta()
        {
            return View();
        }
        public IActionResult Himeko()
        {
            return View();
        }
        public IActionResult FireMC()
        {
            return View();
        }
        public IActionResult Acheron()
        {
            return View();
        }
        public IActionResult Arlan()
        {
            return View();
        }
        public IActionResult Bailu()
        {
            return View();
        }
        public IActionResult Jingyuan()
        {
            return View();
        }
        public IActionResult Kafka()
        {
            return View();
        }
        public IActionResult Serval()
        {
            return View();
        }
        public IActionResult Tingyun()
        {
            return View();
        }
        public IActionResult Gepard()
        {
            return View();
        }
        public IActionResult Herta()
        {
            return View();
        }
        public IActionResult Jingliu()
        {
            return View();
        }
        public IActionResult MarchIce()
        {
            return View();
        }
        public IActionResult Misha()
        {
            return View();
        }
        public IActionResult Pela()
        {
            return View();
        }
        public IActionResult Ruanmei()
        {
            return View();
        }
        public IActionResult Yangqing()
        {
            return View();
        }
        public IActionResult Blackswan()
        {
            return View();
        }
        public IActionResult Blade()
        {
            return View();
        }
        public IActionResult Bronya()
        {
            return View();
        }
        public IActionResult Danheng()
        {
            return View();
        }
        public IActionResult Huohuo()
        {
            return View();
        }
        public IActionResult Sampo()
        {
            return View();
        }
        public IActionResult Fuxuan()
        {
            return View();
        }
        public IActionResult Lynx()
        {
            return View();
        }
        public IActionResult Qingque()
        {
            return View();
        }
        public IActionResult Seele()
        {
            return View();
        }
        public IActionResult Silverwolf()
        {
            return View();
        }
        public IActionResult Sparkle()
        {
            return View();
        }
        public IActionResult Xueyi()
        {
            return View();
        }
        public IActionResult HarmonyMC()
        {
            return View();
        }
        public IActionResult Aventurine()
        {
            return View();
        }
        public IActionResult Drratio()
        {
            return View();
        }
        public IActionResult Imbibitor()
        {
            return View();
        }
        public IActionResult Luocha()
        {
            return View();
        }
        public IActionResult Yukong()
        {
            return View();
        }
        public IActionResult Welt()
        {
            return View();
        }
        public IActionResult Guides()
        {
            return View();
        }
        public IActionResult Speedguide()
        {
            return View();
        }
        public IActionResult Pokkeletter()
        {
            return View();
        }
        public IActionResult Sources()
        {
            return View();
        }
        private readonly AzureContext _context;

        public HSRController(AzureContext context)
        {
            _context = context;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email")] Newsletter newsletter)
        {
            if (ModelState.IsValid)
            {
                if (!NewsletterExists(newsletter.Email))
                {
                    _context.Add(newsletter);
                    await _context.SaveChangesAsync();
                    ViewData["Message"] = "Thanks for subscribing";
                    return View("Pokkeletter", newsletter);
                }
                else
                {
                    ViewData["Message"] = "Email is already subscribed";
                    return View("Pokkeletter", newsletter);
                }
                
            }
            return View("Pokkeletter", newsletter);
        }
        private bool NewsletterExists(string email)
        {
            return _context.Newsletter.Any(e => e.Email == email);
        }
    }
}

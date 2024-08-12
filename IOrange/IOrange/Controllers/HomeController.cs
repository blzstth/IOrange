using IOrange.Data;
using Microsoft.AspNetCore.Mvc;

namespace IOrange.Controllers
{
    public class HomeController : Controller
    {
        private readonly IorangedatabaseContext _context = new();
        public IActionResult Index()
        {
            return View(_context);
        }
    }
}

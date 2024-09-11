using IOrange.Data;
using IOrange.Services;
using IOrange.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IOrange.Controllers
{
    public class HomeController : Controller
    {
        private readonly IorangedatabaseContext _context = new();
        private readonly ItemService _itemService;
       
        public HomeController(ItemService items)
        {
            _itemService = items;
        }
        public IActionResult Index()
        {
            var username = HttpContext.Session.GetString("Username");
            ViewBag.Username = username;
            var items = _itemService.GetItems().Select(p => new ItemViewModel
            {
                Iid = p.Iid,
                Name = p.Name,
                Amount = p.Amount,
                Price = p.Price,
                Sold  = p.Sold
            }).ToList();
            return View(items);
        }
    }
}

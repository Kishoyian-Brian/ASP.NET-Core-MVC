using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item
            {
                Id = 1,
                Name = "Book"
            };
            return View(item);
        }
    }
} 
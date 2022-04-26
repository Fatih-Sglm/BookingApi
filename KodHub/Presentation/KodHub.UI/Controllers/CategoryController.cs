using Microsoft.AspNetCore.Mvc;

namespace KodHub.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

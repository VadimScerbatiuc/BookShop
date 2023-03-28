using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

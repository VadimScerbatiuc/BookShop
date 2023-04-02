using Books.Data;
using Books.Models;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    public class BooksController : Controller
    {

        private readonly ApplicationDbContext _db;

        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> BookToView = _db.Book;
            return View(BookToView);
        }

        [HttpPost]
        public ActionResult Create(Book obj)
        {
            _db.Book.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Home/Index");
        }
    }
}

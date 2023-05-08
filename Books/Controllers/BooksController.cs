using Books.Data;
using Books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Books.Controllers
{
    public class BooksController : Controller
    {

        private readonly ApplicationDbContext _db;

        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            //formiruem spisok komand dlea peredachi v predsavlenuie
            SelectList genre = new SelectList(_db.Genre, "GenreId", "GenreName");
            ViewBag.Genre = genre;
            return View();

        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Book.Add(book);
                _db.SaveChanges();
                TempData["success"] = "Book created successfylly!";
                return RedirectToAction("Index", "Home");
            }
            return View(book);
        }

    }
}

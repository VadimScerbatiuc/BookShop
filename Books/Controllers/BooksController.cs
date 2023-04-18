using AspNetCoreHero.ToastNotification.Abstractions;
using Books.Data;
using Books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Books.Controllers
{
    public class BooksController : Controller
    {

        private readonly ApplicationDbContext _db;
        private readonly INotyfService _toastNotification;

        public BooksController(ApplicationDbContext db, INotyfService toastNotification )
        {
            _db = db;
            _toastNotification = toastNotification;
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
                _toastNotification.Success("The book was created successfully");
                return RedirectToAction("Index", "Home");
                // Success Toast
               
            }
            return View();
        }

    }
}

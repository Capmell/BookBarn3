using BookBarn.Models;
using BookBarn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;


namespace BookBarn.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookBarnContext _context;

        public BooksController(BookBarnContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.ToList();

            var vm = new BookListViewModel
            {
                Books = books,
                PageTitle = "Available Books",
                TotalCount = books.Count,
                EmptyMessage = "No books are currently available."
            };

            return View(vm);
        }

        [Route("Books/Info")]
        public IActionResult About()
        {
            return View();
        }
    }
}

using BookBarn.Models;
using BookBarn.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace BookBarn.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly BookBarnContext _context;

        public AuthorsController(BookBarnContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var authors = _context.Authors.ToList();

            var vm = new AuthorListViewModel
            {
                Authors = authors,
                PageTitle = "Available Authors",
                TotalCount = authors.Count,
                EmptyMessage = "No Authors are currently available."
            };

            return View(vm);
        }
    }
}

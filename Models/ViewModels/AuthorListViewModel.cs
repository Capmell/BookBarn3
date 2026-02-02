using System.Collections.Generic;
using System.Collections.Generic;
using BookBarn.Models;

namespace BookBarn.ViewModels
{
    public class AuthorListViewModel
    {
        public List<Book> Authors { get; set; } = new();
        public string PageTitle { get; set; } = "Authors";
        public int TotalCount { get; set; }
        public string EmptyMessage { get; set; } = "No Authors found.";
    }
}

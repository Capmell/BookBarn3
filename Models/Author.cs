namespace BookBarn.Models
{
    public class Author
    {
        public int Id { get; set; }              // Primary key
        public string Title { get; set; } = "";  // Basic required text
        public string Authors { get; set; } = "";
        public decimal Price { get; set; }


    }
}

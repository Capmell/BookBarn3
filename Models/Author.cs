namespace BookBarn.Models
{
    public class Author
    {
        public int Id { get; set; }              // Primary key
        public string FirstName { get; set; } = "";  // Basic required text
        public string MiddleName { get; set; } = "";
        public string LastName { get; set; } = "";


    }
}

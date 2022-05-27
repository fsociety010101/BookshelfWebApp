namespace BookshelfWebApp.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        // public bool Done { get; set; }

        public Books()
        {
        }
    }
}
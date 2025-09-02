using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Book
{
    public class BookCreateDto
    {
        public string Title { get; set; }

        public int Year { get; set; }

        [Required]
        public string Isbn { get; set; } = null!;

        public string Summary { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public int AuthorId { get; set; }
    }
}

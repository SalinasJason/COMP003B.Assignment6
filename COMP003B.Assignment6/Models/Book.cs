using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        // Collection navigation property
        public virtual ICollection<BookAuthor>? BookAuthors { get; set; }

        public decimal Price { get; set; } // New property added
    }
}

using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; }

        // Collection navigation property
        public virtual ICollection<BookAuthor>? BookAuthors { get; set; }


    }
}

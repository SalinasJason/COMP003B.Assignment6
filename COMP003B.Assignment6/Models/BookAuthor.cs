namespace COMP003B.Assignment6.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        // Nullable navigation properties
        public virtual Book? Book { get; set; }
        public virtual Author? Author { get; set; }
        //


    }
}

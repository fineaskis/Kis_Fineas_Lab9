namespace Kis_Fineas_Lab8.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

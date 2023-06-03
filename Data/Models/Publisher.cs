namespace My_Books.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public int Name { get; set; }
        //Nevigation properties
        public List<Book> Books { get; set; }
    }
}

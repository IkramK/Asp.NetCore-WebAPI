using My_Books.Data.Models;

namespace My_Books.Data.ViewModels
{
    public class AutherVM
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Auther> Authers { get; set; }
        public List<Book> Books { get; set; }
    }
}

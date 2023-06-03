using My_Books.Data.Models;

namespace My_Books.Data.ViewModels
{
    public class PublisherVM
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Publisher> Publishers { get; set; }
    }
}

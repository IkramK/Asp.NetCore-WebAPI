using My_Books.Data.Models;

namespace My_Books.Data.ViewModels
{
    public class BookVM
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsRead { get; set; }
        public string? Genre { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string? CoverUrl { get; set; }
        public int PublisherId { get; set; }
        public List<int> AutherIds { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace My_Books.Data.Models
{
    public class Books_Authers
    {
        public int id { get; set; }
        [ForeignKey("Auther")]
        public int AutherId { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Auther Auther { get; set; }
        public Book Book { get; set; }
    }
}

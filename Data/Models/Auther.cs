namespace My_Books.Data.Models
{
    public class Auther
    {
        public int id { get; set; }
        public string Name { get; set; }
        //Nevigation properties
        public List<Books_Authers> Books_Authers { get; set; }
    }
}

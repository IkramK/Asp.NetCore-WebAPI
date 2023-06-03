using My_Books.Data.Models;
using My_Books.Data.ViewModels;

namespace My_Books.Data.Services
{
    public class BookService
    {
        private readonly AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM bookVM)
        {
            Book _book = new Book()
            {
                Title = bookVM.Title,
                Description = bookVM.Description,
                IsRead = bookVM.IsRead,
                DateRead = bookVM.IsRead ? bookVM.DateRead : null,
                Rate = bookVM.IsRead ? bookVM.Rate : null,
                CoverUrl = bookVM.CoverUrl,
                Genre = bookVM.Genre,
                DateAdded = DateTime.Now,
                PubId=bookVM.PublisherId
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
            foreach (var id in bookVM.AutherIds)
            {
                Books_Authers books_Authers = new Books_Authers()
                {
                    AutherId=id,
                    BookId=_book.Id
                };
                _context.Books_Authers.Add(books_Authers);
                _context.SaveChanges();
            }
        }
        public List<Book> GetBooks()=> _context.Books.ToList();
        public Book? GetBookById(int id) => _context.Books.FirstOrDefault(b=> b.Id==id);
        public Book? UpdateBook(int id,BookVM bookVM)
        {
            var _book = _context.Books.Find(id);
            if (_book!=null)
            {
                    _book.Title = bookVM.Title;
                    _book.Description = bookVM.Description;
                    _book.IsRead = bookVM.IsRead;
                    _book.DateRead = bookVM.IsRead ? bookVM.DateRead : null;
                    _book.Rate = bookVM.IsRead ? bookVM.Rate : null;
                    _book.CoverUrl = bookVM.CoverUrl;
                    _book.Genre = bookVM.Genre;
                _context.Books.Update(_book);
                _context.SaveChanges();
            }
            return _book;
        }
        public bool DeleteBookById(int id)
        {
            var book = _context.Books.Find(id);
            if(book!=null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
                return true;
            }
            return false;
            
        }
        
    }
}

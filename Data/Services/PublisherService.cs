using My_Books.Data;
using My_Books.Data.Models;
using My_Books.Data.ViewModels;

namespace My_Publishers.Data.Services
{
    public class PublisherService
    {
        private readonly AppDbContext _context;
        public PublisherService(AppDbContext context)
        {
            _context = context;
        }
        public void AddPublisher(PublisherVM PublisherVM)
        {
            Publisher _Publisher = new Publisher()
            {
                Name = PublisherVM.Name,

            };
            _context.Publishers.Add(_Publisher);
            _context.SaveChanges();
        }
        public List<Publisher> GetPublishers()=> _context.Publishers.ToList();
        public Publisher? GetPublisherById(int id) => _context.Publishers.FirstOrDefault(b=> b.Id==id);
        public Publisher? UpdatePublisher(int id,PublisherVM PublisherVM)
        {
            var _Publisher = _context.Publishers.Find(id);
            if (_Publisher!=null)
            {
                    _Publisher.Name = PublisherVM.Name;
                _context.Publishers.Update(_Publisher);
                _context.SaveChanges();
            }
            return _Publisher;
        }
        public bool DeletePublisherById(int id)
        {
            var Publisher = _context.Publishers.Find(id);
            if(Publisher!=null)
            {
                _context.Publishers.Remove(Publisher);
                _context.SaveChanges();
                return true;
            }
            return false;
            
        }
        
    }
}

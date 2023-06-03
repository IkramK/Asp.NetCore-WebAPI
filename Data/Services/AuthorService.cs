using My_Books.Data;
using My_Books.Data.Models;
using My_Books.Data.ViewModels;

namespace My_Authers.Data.Services
{
    public class AutherService
    {
        private readonly AppDbContext _context;
        public AutherService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAuther(AutherVM AutherVM)
        {
            Auther _Auther = new Auther()
            {
                Name = AutherVM.Name,

            };
            _context.Authers.Add(_Auther);
            _context.SaveChanges();
        }
        public List<Auther> GetAuthers()=> _context.Authers.ToList();
        public Auther? GetAutherById(int id) => _context.Authers.FirstOrDefault(b=> b.id==id);
        public Auther? UpdateAuther(int id,AutherVM AutherVM)
        {
            var _Auther = _context.Authers.Find(id);
            if (_Auther!=null)
            {
                    _Auther.Name= AutherVM.Name;
                _context.Authers.Update(_Auther);
                _context.SaveChanges();
            }
            return _Auther;
        }
        public bool DeleteAutherById(int id)
        {
            var Auther = _context.Authers.Find(id);
            if(Auther!=null)
            {
                _context.Authers.Remove(Auther);
                _context.SaveChanges();
                return true;
            }
            return false;
            
        }
        
    }
}

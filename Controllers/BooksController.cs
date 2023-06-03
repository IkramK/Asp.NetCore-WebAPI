using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Books.Data.Services;
using My_Books.Data.ViewModels;

namespace My_Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }
        [HttpPost("Add-Book")]
        public IActionResult AddBook(BookVM bookVM)
        {
            _bookService.AddBook(bookVM);
            return Ok();
        }
        [HttpGet("Get-Books")]
        public IActionResult GetAllBooks()
        {
            var books= _bookService.GetBooks();
            return Ok(books);
        }
        [HttpGet("Get-Book_BY_Id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var books = _bookService.GetBookById(id);
            return Ok(books);
        }
        [HttpPut("Update-Book/{id}")]
        public IActionResult UpdateBook(int id, BookVM bookVM)
        {
            var book = _bookService.UpdateBook(id,bookVM);
            return Ok(book);
        }
        [HttpDelete("Delete-Book/{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _bookService.DeleteBookById(id);
            return Ok(book);
        }
    }
}

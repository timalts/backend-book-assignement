using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend_book_assignement.Data;
using System.Linq;
using backend_book_assignement.Models;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly Context _context;

        public BooksController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Books>>> GetBooks()
        {
            var book = from books in _context.Book
            select new Books
            {
                id = books.id,
                price = books.price,
                isbn = books.isbn,
            };

            return await book.ToListAsync();
        }
    }
}
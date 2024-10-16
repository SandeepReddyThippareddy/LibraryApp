using LibraryApp.API.DTOs;
using LibraryApp.Data.Repositories.Interfaces;
using LibraryApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // Get all books - Accessible by Librarians and Students
        [HttpGet]
        [Authorize(Roles = "Librarian, Student")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _bookRepository.GetAllBooksAsync();
            return Ok(books);
        }

        // Get a specific book by ID - Accessible by Librarians and Students
        [HttpGet("{id}")]
        [Authorize(Roles = "Librarian, Student")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        // Add a new book - Accessible only by Librarians
        [HttpPost]
        [Authorize(Roles = "Librarian")]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            await _bookRepository.AddBookAsync(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        // Update a book - Accessible only by Librarians
        [HttpPut("{id}")]
        [Authorize(Roles = "Librarian")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            if (id != book.Id) return BadRequest();
            var existingBook = await _bookRepository.GetBookByIdAsync(id);
            if (existingBook == null) return NotFound();

            await _bookRepository.UpdateBookAsync(book);
            return NoContent();
        }

        // Delete a book - Accessible only by Librarians
        [HttpDelete("{id}")]
        [Authorize(Roles = "Librarian")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookRepository.DeleteBookAsync(id);
            return NoContent();
        }

        // Update book borrow status
        [HttpPut("{id}/borrow")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> UpdateBookStatus(int id, [FromBody] BookStatusDto statusDto)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null) return NotFound();

            book.IsBorrowed = statusDto.IsBorrowed;  
            await _bookRepository.UpdateBookAsync(book);

            return Ok(new { message = statusDto.IsBorrowed ? "Book borrowed" : "Book returned" });
        }

    }
}

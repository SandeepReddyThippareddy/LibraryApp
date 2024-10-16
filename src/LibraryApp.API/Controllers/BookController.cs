using LibraryApp.Data.Repositories.Interfaces;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using LibraryApp.API.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace LibraryApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookController(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        // api/book
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _bookRepository.GetAllBooksAsync();
            var bookDtos = _mapper.Map<IEnumerable<BookDto>>(books);
            return Ok(bookDtos);
        }

        // api/book/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            var bookDto = _mapper.Map<BookDto>(book);
            return Ok(bookDto);
        }

        // api/book
        [HttpPost]
        [Authorize(Policy = "LibrarianOnly")]
        public async Task<IActionResult> AddBook([FromBody] BookDto bookDto)
        {
            var book = _mapper.Map<Book>(bookDto);
            await _bookRepository.AddBookAsync(book);
            var createdBookDto = _mapper.Map<BookDto>(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, createdBookDto);
        }

        // api/book/{id}
        [HttpPut("{id}")]
        [Authorize(Policy = "LibrarianOnly")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] BookDto bookDto)
        {
            if (id != bookDto.Id)
            {
                return BadRequest();
            }

            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _mapper.Map(bookDto, book);
            await _bookRepository.UpdateBookAsync(book);

            return NoContent();
        }

        // api/book/{id}
        [HttpDelete("{id}")]
        [Authorize(Policy = "LibrarianOnly")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookRepository.DeleteBookAsync(id);
            return NoContent();
        }

        // api/book/{id}/borrow
        [HttpPut("{id}/borrow")]
        [Authorize(Roles = "StudentOnly")]
        public async Task<IActionResult> UpdateBookStatus(int id, [FromBody] bool isBorrowed)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null) return NotFound();

            book.IsBorrowed = isBorrowed;
            await _bookRepository.UpdateBookAsync(book);

            return Ok(new { message = isBorrowed ? "Book borrowed" : "Book returned" });
        }
    }
}

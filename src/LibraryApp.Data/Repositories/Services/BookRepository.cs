using LibraryApp.Data.Repositories.Interfaces;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data.Repositories
{
    /// <summary>
    /// Implementation of the IBookRepository interface for managing books.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="BookRepository"/> class.
    /// </remarks>
    /// <param name="context">The database context.</param>
    public class BookRepository(LibraryContext context) : IBookRepository
    {
        private readonly LibraryContext _context = context;

        /// <summary>
        /// Gets all books from the library.
        /// </summary>
        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _context.Books.Include(b => b.Reviews).ToListAsync();
        }

        /// <summary>
        /// Gets a book by its unique identifier.
        /// </summary>
        public async Task<Book?> GetBookByIdAsync(int id)
        {
            return await _context.Books.Include(b => b.Borrowers).Include(b => b.Reviews).FirstOrDefaultAsync(b => b.Id == id);
        }

        /// <summary>
        /// Adds a new book to the library.
        /// </summary>
        public async Task AddBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates an existing book.
        /// </summary>
        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a book by its unique identifier.
        /// </summary>
        public async Task DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
    }
}

using LibraryApp.Models;

namespace LibraryApp.Data.Repositories.Interfaces
{
    /// <summary>
    /// Interface for managing books in the library.
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Gets all books from the library.
        /// </summary>
        /// <returns>A collection of books.</returns>
        Task<IEnumerable<Book>> GetAllBooksAsync();

        /// <summary>
        /// Gets a book by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <returns>The book with the specified id.</returns>
        Task<Book?> GetBookByIdAsync(int id);

        /// <summary>
        /// Adds a new book to the library.
        /// </summary>
        /// <param name="book">The book to add.</param>
        Task AddBookAsync(Book book);

        /// <summary>
        /// Updates an existing book.
        /// </summary>
        /// <param name="book">The book with updated information.</param>
        Task UpdateBookAsync(Book book);

        /// <summary>
        /// Deletes a book by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the book to delete.</param>
        Task DeleteBookAsync(int id);
    }
}

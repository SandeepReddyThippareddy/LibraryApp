using LibraryApp.Models;

namespace LibraryApp.Data.Repositories.Interfaces
{
    /// <summary>
    /// Interface for managing reviews in the library system.
    /// </summary>
    public interface IReviewRepository
    {
        /// <summary>
        /// Gets all reviews for a specific book.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book.</param>
        /// <returns>A collection of reviews for the specified book.</returns>
        Task<IEnumerable<Review>> GetReviewsByBookIdAsync(int bookId);

        /// <summary>
        /// Adds a new review to the system.
        /// </summary>
        /// <param name="review">The review to add.</param>
        Task AddReviewAsync(Review review);
    }
}

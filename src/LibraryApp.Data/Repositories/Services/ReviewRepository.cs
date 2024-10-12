using LibraryApp.Data.Repositories.Interfaces;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data.Repositories
{
    /// <summary>
    /// Implementation of the IReviewRepository interface for managing reviews.
    /// </summary>
    public class ReviewRepository : IReviewRepository
    {
        private readonly LibraryContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public ReviewRepository(LibraryContext context) => _context = context;

        /// <summary>
        /// Gets all reviews for a specific book.
        /// </summary>
        public async Task<IEnumerable<Review>> GetReviewsByBookIdAsync(int bookId)
        {
            return await _context.Reviews
                .Where(r => r.BookId == bookId)
                .ToListAsync();
        }

        /// <summary>
        /// Adds a new review to the system.
        /// </summary>
        public async Task AddReviewAsync(Review review)
        {
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
        }
    }
}

using LibraryApp.Data.Repositories.Interfaces;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data.Repositories
{
    /// <summary>
    /// Implementation of the IUserRepository interface for managing user operations.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="UserRepository"/> class.
    /// </remarks>
    /// <param name="context">The database context.</param>
    public class UserRepository(LibraryContext context) : IUserRepository
    {
        private readonly LibraryContext _context = context;

        /// <summary>
        /// Gets a collection of all librarians in the system.
        /// </summary>
        public async Task<IEnumerable<User>> GetAllLibrariansAsync()
        {
            return await _context.Users
                .Where(u => u.IsLibrarian)
                .ToListAsync();
        }

        /// <summary>
        /// Gets a collection of all customers in the system.
        /// </summary>
        public async Task<IEnumerable<User>> GetAllCustomersAsync()
        {
            return await _context.Users
                .Where(u => !u.IsLibrarian)
                .ToListAsync();
        }
    }
}

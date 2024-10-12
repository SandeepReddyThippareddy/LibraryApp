using LibraryApp.Models;

namespace LibraryApp.Data.Repositories.Interfaces
{
    /// <summary>
    /// Interface for managing user operations in the library system.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Gets all librarians in the system.
        /// </summary>
        /// <returns>A collection of librarian users.</returns>
        Task<IEnumerable<User>> GetAllLibrariansAsync();

        /// <summary>
        /// Gets all customers in the system.
        /// </summary>
        /// <returns>A collection of customer users.</returns>
        Task<IEnumerable<User>> GetAllCustomersAsync();
    }
}

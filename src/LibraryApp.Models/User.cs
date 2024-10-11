using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace LibraryApp.Models
{
    /// <summary>
    /// Represents a user in the library system. A user can either be a librarian or a customer.
    /// Librarians can manage books, while customers can borrow books and leave reviews.
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Gets or sets a value indicating whether the user is a librarian.
        /// True if the user is a librarian; otherwise, false.
        /// </summary>
        [Required(ErrorMessage = "User type must be specified.")]
        public bool IsLibrarian { get; set; }

        /// <summary>
        /// Gets or sets the collection of books borrowed by the customer.
        /// </summary>
        public ICollection<Book> BorrowedBooks { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            BorrowedBooks = new List<Book>();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    /// <summary>
    /// Represents a user in the library system. A user can either be a librarian or a student.
    /// Librarians can manage books, while students can borrow books and leave reviews.
    /// </summary>
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is a librarian.
        /// True if the user is a librarian; otherwise, false.
        /// </summary>
        [Required(ErrorMessage = "User type must be specified.")]
        public bool IsLibrarian { get; set; }

        /// <summary>
        /// Gets or sets the collection of books borrowed by the student.
        /// </summary>
        public ICollection<Book> BorrowedBooks { get; set; }

        // Collection of reviews the user has written
        public ICollection<Review> Reviews { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public AppUser()
        {
            BorrowedBooks = [];
            Reviews = [];
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    /// <summary>
    /// Represents a review left by a customer for a book.
    /// Contains a rating, a message, and references to the associated book and user.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Gets or sets the unique identifier for the review.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the review message left by the customer.
        /// </summary>
        [StringLength(500, ErrorMessage = "Message cannot exceed 500 characters.")]

        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the rating given by the customer (from 1 to 5 stars).
        /// </summary>
        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the book this review is associated with.
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the book that this review is for.
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who left the review.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user who left the review.
        /// </summary>
        public AppUser User { get; set; }
    }
}

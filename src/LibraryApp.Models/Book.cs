using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    /// <summary>
    /// Represents a book in the library system.
    /// Contains metadata about the book and its associated reviews.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the unique identifier for the book.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        [Required(ErrorMessage = "Author is required.")]
        [StringLength(100, ErrorMessage = "Author cannot exceed 100 characters.")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets a brief description of the book.
        /// </summary>
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]

        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the URL for the cover image of the book.
        /// </summary>
        public string CoverImage { get; set; }

        /// <summary>
        /// Gets or sets the name of the book's publisher.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the date the book was published.
        /// </summary>
        [Required(ErrorMessage = "Publication date is required.")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Book), "ValidatePublicationDate")]
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// Gets or sets the category or genre of the book.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the ISBN of the book.
        /// </summary>
        [Required(ErrorMessage = "ISBN is required.")]
        [RegularExpression(@"^[\d-]+$", ErrorMessage = "Invalid ISBN format.")]
        public string ISBN { get; set; }

        /// <summary>
        /// Gets or sets the number of pages in the book.
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "Page count must be greater than 0.")]
        public int PageCount { get; set; }

        /// <summary>
        /// Gets or sets the average user rating for the book (from 1 to 5 stars).
        /// </summary>
        public double AverageRating { get; set; }


        /// <summary>
        /// Gets and sets the status of the book
        /// </summary>
        public bool IsBorrowed { get; set; }


        /// <summary>
        /// Gets or Sets the list of borrowers
        /// </summary>
        public List<AppUser> Borrowers { get; set; }

        public ICollection<Comment> Reviews { get; set; } = new List<Comment>();



        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        public Book()
        {
            Reviews = [];
        }

        /// <summary>
        /// Custom validator for publication date
        /// </summary>
        /// <param name="publicationDate"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static ValidationResult ValidatePublicationDate(DateTime publicationDate, ValidationContext context)
        {
            if (publicationDate > DateTime.Now)
            {
                return new ValidationResult("Publication date cannot be in the future.");
            }
            return ValidationResult.Success;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class LibraryContext
    {
                /// <summary>
        /// Gets or sets the DbSet representing the collection of books in the library.
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets the DbSet representing the collection of reviews in the library.
        /// </summary>
        public DbSet<Review> Reviews { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryContext"/> class with the specified options.
        /// </summary>
        /// <param name="options">The options to be used by the DbContext.</param>
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Configures the model relationships and other constraints.
        /// </summary>
        /// <param name="modelBuilder">The model builder used to configure the database schema.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BookId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.BorrowedBooks)
                .HasForeignKey(r => r.UserId);
        }
    }
}
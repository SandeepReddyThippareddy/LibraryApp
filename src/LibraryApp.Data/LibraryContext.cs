using Bogus;
using LibraryApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data
{
    /// <summary>
    /// Represents the database context for the library system, managing entities like Book, User, and Review.
    /// Inherits from IdentityDbContext to include Identity-related tables.
    /// </summary>
    public class LibraryContext : IdentityDbContext<AppUser>
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

            // Configure the many-to-many relationship between Book and AppUser (borrowers)
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Borrowers)
                .WithMany(u => u.BorrowedBooks)
                .UsingEntity(j => j.ToTable("BookBorrowers"));

            // Existing configurations for Review
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seeding the initial data using Bogus
            SeedBooks(modelBuilder);
            SeedUsers(modelBuilder);
        }

        private void SeedBooks(ModelBuilder modelBuilder)
        {
            var bookFaker = new Faker<Book>()
                .RuleFor(b => b.Id, f => f.IndexFaker + 1)
                .RuleFor(b => b.Title, f => f.Lorem.Sentence(3))
                .RuleFor(b => b.Author, f => f.Person.FullName)
                .RuleFor(b => b.Description, f => f.Lorem.Paragraph(2))
                .RuleFor(b => b.ISBN, f => f.Commerce.Ean13())
                .RuleFor(b => b.PageCount, f => f.Random.Int(100, 1000))
                .RuleFor(b => b.Publisher, f => f.Company.CompanyName())
                .RuleFor(b => b.PublicationDate, f => f.Date.Past(20))
                .RuleFor(b => b.Category, f => f.Commerce.Categories(1)[0]);

            var books = bookFaker.Generate(20);
            modelBuilder.Entity<Book>().HasData(books);
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            var userFaker = new Faker<AppUser>()
                .RuleFor(u => u.Id, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.UserName, f => f.Internet.UserName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.IsLibrarian, f => f.Random.Bool())
                .RuleFor(u => u.NormalizedUserName, f => f.Internet.UserName().ToUpper())
                .RuleFor(u => u.NormalizedEmail, f => f.Internet.Email().ToUpper())
                .RuleFor(u => u.PasswordHash, f => new PasswordHasher<AppUser>().HashPassword(null, "password123"));

            var users = userFaker.Generate(10);
            modelBuilder.Entity<AppUser>().HasData(users);
        }
    }
}

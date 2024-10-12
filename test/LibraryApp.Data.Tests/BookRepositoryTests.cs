using LibraryApp.Data.Repositories;
using Moq;
using Microsoft.EntityFrameworkCore;
using LibraryApp.Data;
using LibraryApp.Models;

namespace LibraryApp.Tests.Repositories
{
    public class BookRepositoryTests
    {
        private readonly Mock<LibraryContext> _contextMock;
        private readonly Mock<DbSet<Book>> _dbSetMock;
        private readonly BookRepository _bookRepository;

        public BookRepositoryTests()
        {
            // Set up mock data
            var testBooks = new List<Book>
            {
                new Book { Id = 1, Title = "Test Book 1" },
                new Book { Id = 2, Title = "Test Book 2" }
            }.AsQueryable();

            // Mock DbSet<Book>
            _dbSetMock = new Mock<DbSet<Book>>();

            // Mock the queryable behavior of DbSet<Book>
            _dbSetMock.As<IQueryable<Book>>().Setup(m => m.Provider).Returns(testBooks.Provider);
            _dbSetMock.As<IQueryable<Book>>().Setup(m => m.Expression).Returns(testBooks.Expression);
            _dbSetMock.As<IQueryable<Book>>().Setup(m => m.ElementType).Returns(testBooks.ElementType);
            _dbSetMock.As<IQueryable<Book>>().Setup(m => m.GetEnumerator()).Returns(testBooks.GetEnumerator());

            // Mock FindAsync behavior for Book with Id 1
            _dbSetMock.Setup(m => m.FindAsync(It.IsAny<object[]>()))
                .ReturnsAsync((object[] ids) => testBooks.FirstOrDefault(b => b.Id == (int)ids[0]));

            // Set up LibraryContext to return the mocked DbSet<Book>
            _contextMock = new Mock<LibraryContext>(new DbContextOptions<LibraryContext>());
            _contextMock.Setup(c => c.Books).Returns(_dbSetMock.Object);

            _bookRepository = new BookRepository(_contextMock.Object);
        }

        [Fact]
        public async Task GetBookByIdAsync_ReturnsBook_WhenBookExists()
        {
            // Act
            var result = await _bookRepository.GetBookByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Test Book 1", result.Title);
        }

        [Fact]
        public async Task GetBookByIdAsync_ReturnsNull_WhenBookDoesNotExist()
        {
            // Act
            var result = await _bookRepository.GetBookByIdAsync(99);

            // Assert
            Assert.Null(result);
        }
    }
}

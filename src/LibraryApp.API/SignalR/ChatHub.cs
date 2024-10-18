using Microsoft.AspNetCore.SignalR;
using LibraryApp.Data;
using Microsoft.EntityFrameworkCore;
using LibraryApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace LibraryApp.API.SignalR
{
    [Authorize]
    public class ChatHub : Hub
    {
        private readonly LibraryContext _context;

        public ChatHub(LibraryContext context)
        {
            _context = context;
        }

        public async Task SendComment(string body, int bookId)
        {
            var user = Context.User.Identity.Name;

            var book = await _context.Books
                .Include(b => b.Reviews)
                .FirstOrDefaultAsync(b => b.Id == bookId);

            if (book == null) return;

            var comment = new Comment
            {
                Body = body,
                Author = await _context.Users.FirstOrDefaultAsync(u => u.UserName == user),
                Book = book,
                CreatedAt = DateTime.UtcNow
            };

            book.Reviews.Add(comment);

            var success = await _context.SaveChangesAsync() > 0;

            if (success)
            {
                var commentDto = new
                {
                    comment.Id,
                    comment.Body,
                    comment.CreatedAt,
                    Author = comment.Author.UserName
                };
                await Clients.Group(bookId.ToString()).SendAsync("ReceiveComment", commentDto);
            }
        }

        public override async Task OnConnectedAsync()
        {
            var httpContext = Context.GetHttpContext();
            var bookId = httpContext.Request.Query["BookId"];

            if (int.TryParse(bookId, out var parsedBookId))
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, bookId);
                var comments = await _context.Comments
                    .Where(c => c.Book.Id == parsedBookId)
                    .Select(c => new
                    {
                        c.Id,
                        c.Body,
                        c.CreatedAt,
                        c.Author.UserName
                    }).ToListAsync();

                await Clients.Caller.SendAsync("LoadComments", comments);
            }
        }
    }
}

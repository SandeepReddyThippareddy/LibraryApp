using LibraryApp.API.Utilities.Enums;

namespace LibraryApp.API.Interfaces
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(string email, string subject, string body);
    }
}

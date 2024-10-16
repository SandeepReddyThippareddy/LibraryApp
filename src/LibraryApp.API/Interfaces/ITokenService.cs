using LibraryApp.Models;

namespace LibraryApp.API.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}

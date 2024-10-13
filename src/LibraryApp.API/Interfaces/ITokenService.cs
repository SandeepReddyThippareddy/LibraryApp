using LibraryApp.Models;

namespace LibraryApp.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}

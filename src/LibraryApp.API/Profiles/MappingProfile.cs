using AutoMapper;
using LibraryApp.API.DTOs;
using LibraryApp.Models;

namespace LibraryApp.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
        }
    }
}

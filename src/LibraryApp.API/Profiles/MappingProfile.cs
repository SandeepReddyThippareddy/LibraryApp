using AutoMapper;
using LibraryApp.API.DTOs;
using LibraryApp.Models;

namespace LibraryApp.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDto, Book>();
            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}

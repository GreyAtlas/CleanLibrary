using AutoMapper;
using CleanLibrary.Domain.Entities;

namespace CleanLibrary.Application.Features.Books
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<BookSearchTermsDTO, Book>();
            
        }
    }
}

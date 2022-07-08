using Amnil.BookPublication.Books;
using Amnil.BookPublication.Publications;
using AutoMapper;

namespace Amnil.BookPublication;

public class BookPublicationApplicationAutoMapperProfile : Profile
{
    public BookPublicationApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<CreateUpdatePublicationDto, Publication>();
        CreateMap<Publication, PublicationDto>();
    }
}

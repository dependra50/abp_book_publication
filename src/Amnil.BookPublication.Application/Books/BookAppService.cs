using System;
using System.Threading.Tasks;
using AutoMapper;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Amnil.BookPublication.Books
{
	public class BookAppService :
        CrudAppService<//Define Crud methods
        Book,
        BookDto,//Used to show Book
        Guid,//Primary key of book entity
        PagedAndSortedResultRequestDto,//Used for paging/sorting
        CreateUpdateBookDto>,//Used to create/update a book
        IBookAppService//Implement the IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookAppService(IRepository<Book , Guid> repository ,
                              IBookRepository bookRepository ,
                              IMapper mapper) : base(repository)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
            _mapper = mapper;
        }

        public async Task<BookDto> FindBookByISBNNumberAsync(FindBookByISBNDto findBookByISBNDto)
        {
            var bookFromRepo = await _bookRepository.FindBookByISBNNumberAsync(findBookByISBNDto.ISBNNumber);
            var bookDto = _mapper.Map<Book, BookDto>(bookFromRepo);
            return bookDto;
        }

        public async Task<BookDto> FindByBookAndPublicationNameAsync(FindBookByBookAndPublicationNameDto findBookByBookAndPublicationNameDto)
        {
            var bookFromRepo =  await _bookRepository.FindByBookAndPublicationNameAsync(findBookByBookAndPublicationNameDto.BookName,
                                                                          findBookByBookAndPublicationNameDto.PublicationName);

            var bookDto = _mapper.Map<Book, BookDto>(bookFromRepo);
            return bookDto;

        }

        public async Task<BookDto> FindByBookNameAsync(FindBookByNameDto findBookByNameDto)
        {
            var bookFromRepo = await _bookRepository.FindByBookNameAsync(findBookByNameDto.BookName);
            var bookDto = _mapper.Map<Book, BookDto>(bookFromRepo);
            return bookDto;

        }
    }
}


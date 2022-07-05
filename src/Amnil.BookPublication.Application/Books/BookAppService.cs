using System;
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
        public BookAppService(IRepository<Book , Guid> repository) : base(repository)
        {

        }
	}
}


using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace Amnil.BookPublication.Books
{
	public interface IBookAppService :
		ICrudAppService<//Define Crud methods
		BookDto,//Used to show Book
		Guid ,//Primary key of book entity
		PagedAndSortedResultRequestDto,//Used for paging/sorting
		CreateUpdateBookDto>//Used to create/update a book
	{
		
	}
}


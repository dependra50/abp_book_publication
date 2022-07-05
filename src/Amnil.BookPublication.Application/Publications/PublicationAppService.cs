using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Amnil.BookPublication.Publications
{
	public class PublicationAppService :
        CrudAppService<//Define Crud methods
        Publication,
        PublicationDto,//Used to show Book
        Guid,//Primary key of book entity
        PagedAndSortedResultRequestDto,//Used for paging/sorting
        CreateUpdatePublicationDto>,//Used to create/update a book
        IPublicationAppService//Implement the IBookService
    {
		public PublicationAppService(IRepository<Publication , Guid> repository) : base(repository)
		{


		}
	}
}


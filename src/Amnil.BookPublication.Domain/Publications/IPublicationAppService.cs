using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Amnil.BookPublication.Publications
{
	public interface IPublicationAppService :
        ICrudAppService<//Define Crud methods
        PublicationDto,//Used to show Publication
        Guid,//Primary key of book entity
        PagedAndSortedResultRequestDto,//Used for paging/sorting
        CreateUpdatePublicationDto>//Used to create/update a publication
    {

	}
}


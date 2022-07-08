using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Amnil.BookPublication.Publications
{
	public interface IPublicationRepository : IRepository<Publication , Guid>
	{
		Task<Publication> FindPublicationByNameAsync(string publicationName);
		

	}
}


using System;
using System.Threading.Tasks;
using Amnil.BookPublication.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Amnil.BookPublication.Publications
{
	public class EfCorePublicationRepository :
		EfCoreRepository<BookPublicationDbContext , Publication , Guid> ,
		IPublicationRepository
	{
		public EfCorePublicationRepository(IDbContextProvider<BookPublicationDbContext> dbContextProvider) :
			base(dbContextProvider)
		{
		}

       

        public async Task<Publication> FindPublicationByNameAsync(string publicationName)
        {
            var dbSet = await GetDbSetAsync();
			return await dbSet.FirstOrDefaultAsync(p => p.Name == publicationName);
        }
    }
}


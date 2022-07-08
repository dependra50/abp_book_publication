using System;
using System.Threading.Tasks;
using Amnil.BookPublication.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Amnil.BookPublication.Books
{
	public class EfCoreBookRepository :
		EfCoreRepository<BookPublicationDbContext , Book , Guid> ,
		IBookRepository
	{
		public EfCoreBookRepository(IDbContextProvider<BookPublicationDbContext> dbContextProvider) :
			base(dbContextProvider)

		{


		}

        public async Task<Book> FindBookByISBNNumberAsync(string isbnNumber)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(b => b.ISBN == isbnNumber);
        }

        public async Task<Book> FindByBookAndPublicationNameAsync(string bookName, string publicationName)
        {
            var dbset = await GetDbSetAsync();
            return await dbset.FirstOrDefaultAsync(b => b.Name == bookName &&
                                                        b.Publication.Name == publicationName);
        }

        public async Task<Book> FindByBookNameAsync(string bookName)
        {
            var dbset = await GetDbSetAsync();
            return await dbset.FirstOrDefaultAsync(b => b.Name == bookName);
                                                       
        }
    }
}


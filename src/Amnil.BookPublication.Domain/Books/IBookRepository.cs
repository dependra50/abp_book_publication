using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Amnil.BookPublication.Books
{
	public interface IBookRepository : IRepository<Book , Guid>
	{
		Task<Book> FindByBookAndPublicationNameAsync(string bookName, string publicationName);
		Task<Book> FindByBookNameAsync(string bookName);
        Task<Book> FindBookByISBNNumberAsync(string isbnNumber);

    }
}


using System;
using Volo.Abp.Application.Dtos;

namespace Amnil.BookPublication.Books
{
	public class BookDto :  AuditedEntityDto<Guid>
	{
		public string Name { get; set; }

		public BookType Type { get; set; }

        public string ISBN { get; set; }

        public string Author { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Edition { get; set; }

        public float Price { get; set; }

        public Guid PublicationId { get; set; }

        public string PublicationName { get; set; }
    }
}


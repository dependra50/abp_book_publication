using System;
using Amnil.BookPublication.Publications;
using Volo.Abp.Domain.Entities.Auditing;

namespace Amnil.BookPublication.Books
{
	public class Book : AuditedAggregateRoot<Guid>
	{
        
        public string Name { get; set; }
        
        public string ISBN { get; set; }
        
        public string Author { get; set; }
        
        public DateTime PublishedDate { get; set; }
        
        public string Edition { get; set; }
        
        public float Price { get; set; }

        public BookType Type { get; set; }


        public Guid PublicationId { get; set; }
        public Publication Publication { get; set; }
    }
}


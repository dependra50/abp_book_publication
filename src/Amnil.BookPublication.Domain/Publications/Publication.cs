using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Amnil.BookPublication.Books;
using Volo.Abp.Domain.Entities.Auditing;

namespace Amnil.BookPublication.Publications
{
	public class Publication : AuditedAggregateRoot<Guid>
    {
        
        public string Name { get; set; }
        
        public string Country { get; set; }
        
        [EmailAddress]        
        public string Email { get; set; }
        
        [Phone]
        public string PhoneNumber { get; set; }


        public DateTime PublicationEstablishedDate { get; set; }


        public List<Book> Books { get; set; }
    }
}


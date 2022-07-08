using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Amnil.BookPublication.Books;
using Volo.Abp.Application.Dtos;

namespace Amnil.BookPublication.Publications
{
	public class PublicationDto : AuditedEntityDto<Guid>
	{
        public string Name { get; set; }

        public string Country { get; set; }

        
        public string Email { get; set; }

        
        public string PhoneNumber { get; set; }

        
        public DateTime PublicationEstablishedDate { get; set; }


        public List<Book> Books { get; set; }
    }
}


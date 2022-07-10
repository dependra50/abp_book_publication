using System;
using System.ComponentModel.DataAnnotations;

namespace Amnil.BookPublication.Publications
{
	public class CreateUpdatePublicationDto
	{
        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime PublicationEstablishedDate { get; set; }


        
    }
}


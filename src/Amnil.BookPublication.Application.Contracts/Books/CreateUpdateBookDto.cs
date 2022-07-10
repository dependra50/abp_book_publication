using System;
using System.ComponentModel.DataAnnotations;

namespace Amnil.BookPublication.Books
{
	public class CreateUpdateBookDto
	{
        [Required]
        public string Name { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
        [Required]
        public string Edition { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public BookType Type { get; set; }

        [Required]
        public Guid PublicationId { get; set; }
    }
}


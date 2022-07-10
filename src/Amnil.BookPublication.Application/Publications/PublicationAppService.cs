using System;
using System.Threading.Tasks;
using AutoMapper;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Amnil.BookPublication.Publications
{
	public class PublicationAppService :
        CrudAppService<//Define Crud methods
        Publication,
        PublicationDto,//Used to show Book
        Guid,//Primary key of book entity
        PagedAndSortedResultRequestDto,//Used for paging/sorting
        CreateUpdatePublicationDto>,//Used to create/update a book
        IPublicationAppService//Implement the IBookService
    {
        private readonly IMapper _mapper;
        private readonly IPublicationRepository _publicationRepository;

        public PublicationAppService(IRepository<Publication , Guid> repository ,
                                    IPublicationRepository publicationRepository ,
                                    IMapper mapper) : base(repository)
		{
            _mapper = mapper;
            _publicationRepository = publicationRepository ?? throw new ArgumentNullException(nameof(publicationRepository));

		}

        public async Task<PublicationDto> FindPublicationByNameAsync(FindPublicationByNameDto findPublicationByNameDto)
        {
            var publicationFromRepo = await _publicationRepository.FindPublicationByNameAsync(findPublicationByNameDto.PublicationName);
            return _mapper.Map<Publication, PublicationDto>(publicationFromRepo);
        }
    }
}


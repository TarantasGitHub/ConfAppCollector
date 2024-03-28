using ConfAppCollector.Application.Interfaces;
using ConfAppCollector.Domain.Entities;
using ConfAppCollector.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Application.UseCases
{
    public class CreateSpeakerAppUseCase: ICreateSpeakerAppUseCase
    {
        private readonly ISpeakerRepository authorRepository;

        public CreateSpeakerAppUseCase(ISpeakerRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task<SpeakerDTO> ExecuteAsync(SpeakerDTO authorDTO, CancellationToken cancellationToken)
        {
            //to do проверить наличие
            Speaker newAuthor = new Speaker()
            {
                Author = authorDTO.Author,
                Name = authorDTO.Name,   
                Description = authorDTO.Description,
                Outline = authorDTO.Outline
            };
            Speaker authorResult = await authorRepository.AddAsync(newAuthor);
            SpeakerDTO authorResultDto = new SpeakerDTO() 
            { 
                Author = authorResult.Author, 
                Outline = authorResult.Outline,
                Name = authorResult.Name,
                Description = authorResult.Description
            };

            return authorResultDto;

        }
    }
}

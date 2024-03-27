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
    public class CreateAutorAppUseCase: ICreateAutorAppUseCase
    {
        private readonly IAuthorRepository authorRepository;

        public CreateAutorAppUseCase(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public Task<SpeakerDTO> ExecuteAsync(SpeakerDTO authorDTO, CancellationToken cancellationToken)
        {
            //to do проверить наличие
            Speaker newAuthor = new Speaker() 
            {
                
            };
        }
    }
}

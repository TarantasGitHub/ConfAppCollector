using ConfAppCollector.Application.Interfaces;
using ConfAppCollector.Infrastructure.Core.Interfaces;

namespace ConfAppCollector.Application.UseCases
{
    public class EditConfApplicationUseCase : IEditConfApplicationUseCase
    {
        private readonly ISpeakerRepository authorRepository;
        
        public EditConfApplicationUseCase(ISpeakerRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task<SpeakerDTO> ExecuteAsync(SpeakerDTO speakerDTO, CancellationToken token)
        {
            throw new NotImplementedException();
        }

    }
}

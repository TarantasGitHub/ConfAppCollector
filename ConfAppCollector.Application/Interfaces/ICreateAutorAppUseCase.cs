using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Application.Interfaces
{
    public interface ICreateAutorAppUseCase
    {
        public Task<SpeakerDTO> ExecuteAsync(SpeakerDTO authorDTO, CancellationToken cancellationToken);

    }
}

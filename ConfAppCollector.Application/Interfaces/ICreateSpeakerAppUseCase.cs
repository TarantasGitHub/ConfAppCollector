﻿namespace ConfAppCollector.Application.Interfaces
{
    public interface ICreateSpeakerAppUseCase
    {
        public Task<SpeakerDTO> ExecuteAsync(SpeakerDTO authorDTO, CancellationToken cancellationToken);

    }
}

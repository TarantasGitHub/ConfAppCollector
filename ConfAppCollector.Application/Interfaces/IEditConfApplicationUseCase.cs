namespace ConfAppCollector.Application.Interfaces
{
    public interface IEditConfApplicationUseCase
    {
        public Task<SpeakerDTO> ExecuteAsync(SpeakerDTO speakerDTO, CancellationToken token);
    }
}

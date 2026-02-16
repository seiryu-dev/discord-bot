using Discord_Bot.Application.UseCases.Polls;

namespace Discord_Bot.Application.Services;

public class PollOrchestrator
{
    private readonly CreatePollUseCase _createPollUseCase;
    private readonly SendPollUseCase _sendPollUseCase;
    
    public PollOrchestrator(CreatePollUseCase createPollUseCase, SendPollUseCase sendPollUseCase)
    {
        _createPollUseCase = createPollUseCase;
        _sendPollUseCase = sendPollUseCase;
    }
    
    public async Task CreateAndSendPoll()
    {
        var poll = _createPollUseCase.Handle();
        await _sendPollUseCase.HandleAsync(poll);
    }
}
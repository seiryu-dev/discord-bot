using Discord_Bot.Application.Interfaces;
using Discord_bot.Domain.Entities;

namespace Discord_Bot.Application.UseCases.Polls;

public class SendPollResultsUseCase
{
    private IDiscordService _discordService;
    public SendPollResultsUseCase(IDiscordService discordService)
    {
        _discordService = discordService;
    }
    
    public async Task HandleAsync(BotPoll botPoll)
    {
        throw new NotImplementedException();
    }
}
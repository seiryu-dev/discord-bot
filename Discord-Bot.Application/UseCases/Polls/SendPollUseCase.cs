using Discord_Bot.Application.Interfaces;
using Discord_bot.Domain.Entities;

namespace Discord_Bot.Application.UseCases.Polls;

public class SendPollUseCase
{
    private IDiscordService _discordService;
    
    public SendPollUseCase(IDiscordService discordService)
    {
        _discordService = discordService;
    }
    
    public async Task HandleAsync(BotPoll poll)
    {
        await _discordService.SendPoll(poll);
    }
}
using Discord_bot.Domain.Entities;

namespace Discord_Bot.Application.UseCases.Polls;

public class CreatePollUseCase
{
    public BotPoll Handle()
    {
        var poll = new BotPoll();
        return poll;
    }
}
using Discord_bot.Domain.Entities;

namespace Discord_Bot.Application.Interfaces;

public interface IDiscordService
{
    public Task StartAsync();
    public Task SendPoll(BotPoll botPoll);
}
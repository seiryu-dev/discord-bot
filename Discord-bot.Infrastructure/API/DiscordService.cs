using Discord_Bot.Application.Interfaces;
using Discord_bot.infrastructure.Configuration;
using Discord;
using Discord.WebSocket;

namespace Discord_Bot.infrastructure.API;

public class DiscordService : IDiscordService
{
    DiscordSocketClient _client;
    private DiscordOptions _discordOptions;

    public DiscordService(DiscordSocketClient client, DiscordOptions discordOptions)
    {
        _client = client;
        _discordOptions = discordOptions;

        _client.Log += LogMessage;
    }
    
    public async Task StartAsync()
    {
        await _client.LoginAsync(TokenType.Bot, _discordOptions.Token);
        await _client.StartAsync();

        await Task.Delay(-1);
    }

    private Task LogMessage(LogMessage message)
    {
        Console.WriteLine(message.ToString());
        return Task.CompletedTask;
    }
}
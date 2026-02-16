using Discord_Bot.Application.Interfaces;
using Discord_bot.Domain.Entities;
using Discord_bot.infrastructure.Configuration;
using Discord;
using Discord.WebSocket;

namespace Discord_Bot.infrastructure.API;

public class DiscordService : IDiscordService
{
    DiscordSocketClient _client;
    private DiscordConfigurations _discordConfigurations;

    public DiscordService(DiscordSocketClient client, DiscordConfigurations discordConfigurations)
    {
        _client = client;
        _discordConfigurations = discordConfigurations;

        _client.Log += LogMessage;
    }
    
    public async Task StartAsync()
    {
        await _client.LoginAsync(TokenType.Bot, _discordConfigurations.Token);
        await _client.StartAsync();

        await Task.Delay(-1);
    }

    private Task LogMessage(LogMessage message)
    {
        Console.WriteLine(message.ToString());
        return Task.CompletedTask;
    }

    public async Task SendPoll(BotPoll botPoll)
    {
        var poll = new PollProperties()
        {
            Question = new()
            {
                Text = botPoll.Question,
            },
            Duration = 6,
            AllowMultiselect = false,
            LayoutType = PollLayout.Default
        };
        
        foreach (var option in botPoll.Options)
        {
            var answer = new PollMediaProperties()
            {
                Text =  option,
            };
            
            poll.Answers.Add(answer);
        }
        
        var guild = _client.GetGuild(_discordConfigurations.GuildId);
        var pollChannel = guild.GetTextChannel(_discordConfigurations.ChannelId);
        await pollChannel.SendMessageAsync(poll: poll);
    }
}
using Discord_Bot.Application.Extensions;
using Discord_Bot.Application.Interfaces;
using Discord_bot.Domain.Extensions;
using Discord_bot.infrastructure.Extensions;
using Discord_bot.Presentation.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Discord_bot.Presentation;

class Program
{
    private static async Task Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddPresentation()
            .AddApplication()
            .AddDomain()
            .AddInfrastructure()
            .BuildServiceProvider();
        
        var discordService = serviceProvider.GetRequiredService<IDiscordService>();
        await discordService.StartAsync();
    }
}

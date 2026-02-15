using Discord_Bot.Application;
using Discord_bot.Domain;
using discord_bot.Extensions;
using discord_bot.infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace discord_bot;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddPresentation()
            .AddApplication()
            .AddDomain()
            .AddInfrastructure()
            .BuildServiceProvider();
    }
}

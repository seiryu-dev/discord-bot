using Discord_Bot.Application.Interfaces;
using Discord_Bot.infrastructure.API;
using Discord_bot.infrastructure.Configuration;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace Discord_bot.infrastructure.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services
            .AddSingleton<IDiscordService, DiscordService>()
            .AddSingleton<DiscordSocketClient>()
            .AddSingleton<DiscordOptions>();
        return services;
    }
}
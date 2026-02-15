using Microsoft.Extensions.DependencyInjection;

namespace discord_bot.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}
using Microsoft.Extensions.DependencyInjection;

namespace discord_bot.infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
using Microsoft.Extensions.DependencyInjection;

namespace Discord_bot.Domain.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        return services;
    }
}
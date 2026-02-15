using Microsoft.Extensions.DependencyInjection;

namespace Discord_Bot.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
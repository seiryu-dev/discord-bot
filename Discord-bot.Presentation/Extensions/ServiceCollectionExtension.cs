using Microsoft.Extensions.DependencyInjection;

namespace Discord_bot.Presentation.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}
using KernUx.Blazor.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KernUx.Blazor.Extensions;

/// <summary>
/// Erweiterungsmethoden zur Registrierung der KernUx.Blazor-Dienste im DI-Container.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registriert alle für KernUx.Blazor benötigten Dienste (<see cref="ThemeService"/> und <see cref="IdGeneratorService"/>).
    /// </summary>
    /// <param name="services">Der <see cref="IServiceCollection"/>, dem die Dienste hinzugefügt werden.</param>
    /// <returns>Dieselbe <see cref="IServiceCollection"/> zur Method-Chaining-Unterstützung.</returns>
    public static IServiceCollection AddKernUx(this IServiceCollection services)
    {
        services.AddScoped<ThemeService>();
        services.AddScoped<IdGeneratorService>();

        return services;
    }
}

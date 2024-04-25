using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Scalar.Net.Validation;

namespace Scalar.Net.Extensions;

/// <summary>
/// Scalar extensions for <see cref="IServiceCollection"/>
/// </summary>
public static class ScalarServiceCollectionExtensions
{
    /// <summary>
    /// Adds Scalar related services to <see cref="IServiceCollection"/>
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <param name="configureScalarOptions">Action for configuring Scalar options</param>
    /// <param name="name">Optional name of options</param>
    /// <returns>Service collection</returns>
    public static IServiceCollection AddScalar(
        this IServiceCollection services,
        Action<ScalarConfigurationOptions>? configureScalarOptions = null,
        string? name = null)
    {
        configureScalarOptions ??= _ => { };
        services.Configure(null, configureScalarOptions);
        services.AddSingleton<IValidateOptions<ScalarConfigurationOptions>, ScalarConfigurationOptionsValidator>();
        services.AddSingleton<ScalarMiddleware>();

        return services;
    }
}
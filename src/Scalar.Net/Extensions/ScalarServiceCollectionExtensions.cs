using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Scalar.Net.Validation;

namespace Scalar.Net.Extensions;

public static class ScalarServiceCollectionExtensions
{
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
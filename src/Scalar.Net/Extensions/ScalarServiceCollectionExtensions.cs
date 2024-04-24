using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

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

internal class ScalarConfigurationOptionsValidator : IValidateOptions<ScalarConfigurationOptions>
{
    public ValidateOptionsResult Validate(
        string? name,
        ScalarConfigurationOptions options)
    {
        if (options.Spec?.Url == null && options.Spec?.Content == null)
            return ValidateOptionsResult.Fail("Scalar configuration not valid!");
        return ValidateOptionsResult.Success;
    }
}
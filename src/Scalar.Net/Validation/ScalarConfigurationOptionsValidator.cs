using Microsoft.Extensions.Options;

namespace Scalar.Net.Validation;

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
using Microsoft.AspNetCore.Builder;

namespace Scalar.Net.Extensions;

/// <summary>
/// Scalar extensions for <see cref="IApplicationBuilder"/>
/// </summary>
public static class ScalarApplicationBuilderExtensions
{
    /// <summary>
    /// Adds Scalar middleware to the target pipeline which will render the appropriate docs page
    /// </summary>
    /// <param name="builder">Application builder</param>
    /// <returns>Application builder</returns>
    public static IApplicationBuilder UseScalar(
        this IApplicationBuilder builder)
    {
        builder.UseMiddleware<ScalarMiddleware>();
        return builder;
    }
}
using Microsoft.AspNetCore.Builder;

namespace Scalar.Net.Extensions;

public static class ScalarApplicationBuilderExtensions
{
    public static IApplicationBuilder UseScalar(
        this IApplicationBuilder builder)
    {
        builder.UseMiddleware<ScalarMiddleware>();
        return builder;
    }
}
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Scalar.Net;

internal sealed class ScalarMiddleware(IOptions<ScalarConfigurationOptions> opts) : IMiddleware
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        WriteIndented = false,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
    };

    public async Task InvokeAsync(
        HttpContext context,
        RequestDelegate next)
    {
        var serializedOptions = JsonSerializer.Serialize(opts.Value, JsonSerializerOptions);
        serializedOptions = HtmlEncoder.Default.Encode(serializedOptions);
        var scalarHtml = Html.CreateHtml(opts.Value, serializedOptions);

        await context.Response.WriteAsync(scalarHtml);
        await next(context);
    }
}
using Scalar.Net;
using Scalar.Net.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScalar(opts => builder.Configuration.GetSection("Scalar").Bind(opts));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Map("/docs", a =>
{
    a.UseScalar();
});

app.Run();

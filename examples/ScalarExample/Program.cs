using System.Reflection;
using Microsoft.OpenApi.Models;
using Scalar.Net.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(opts =>
{
    opts.SwaggerDoc("v1", new OpenApiInfo { Title = "Values API docs", Version = "1" });

    var xmlFile = $"{Assembly.GetEntryAssembly()?.GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    opts.IncludeXmlComments(xmlPath);
});
builder.Services.AddScalar(opts => builder.Configuration.GetSection("Scalar").Bind(opts));
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(opts =>
{
    opts.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
});
app.MapControllers();
app.Map("/docs", a =>
{
    a.UseScalar();
});

app.Run();

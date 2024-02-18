//[assembly: Microsoft.AspNetCore.Mvc.ApiController]

using Asp.Versioning;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddProblemDetails();
builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    // Use Default Version
    options.AssumeDefaultVersionWhenUnspecified = true;
    // Set Default Version
    options.DefaultApiVersion = new ApiVersion(1.0);
    options.ApiVersionReader = ApiVersionReader.Combine(
        new HeaderApiVersionReader("Api-Version", "X-Version"),
        new QueryStringApiVersionReader("api-version", "x-version"),
        new UrlSegmentApiVersionReader(),
        new MediaTypeApiVersionReader("version"));
})
.AddMvc();

var app = builder.Build();

app.MapControllers();

app.Run();

public partial class Program { }

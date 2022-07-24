using turbo_waffle.API.Endpoints;
using turbo_waffle.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddInfrastructrure();

var app = builder.Build();
app
    .AddFilmEndpoints()
    .Run();

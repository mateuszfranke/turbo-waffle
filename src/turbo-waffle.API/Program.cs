using turbo_waffel.Application;
using turbo_waffle.API.Endpoints;
using turbo_waffle.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddApplication()
    .AddInfrastructure();

var app = builder.Build();


app
    .AddFilmEndpoints()
    .AddRepertoireEndpoints()
    .AddCinemaEndpoints()
    .Run();

using turbo_waffle.API.Endpoints;
using turbo_waffle.Core.Repositories;
using turbo_waffle.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddInfrastructrure();

var app = builder.Build();

app.MapGet("cinemas", async (ICinemaRepository repository)=> {

    var cinemas = await repository.GetAsync();
    return Results.Ok(cinemas);

});

app
    .AddFilmEndpoints()
    .Run();

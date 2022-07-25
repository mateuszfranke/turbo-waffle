using Microsoft.AspNetCore.Mvc;
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

app.MapGet("cinema/{id}", async (ICinemaRepository cinemaRepository, Guid id)=> {
    var cinema = await cinemaRepository.GetAsync(id);
    var response = cinema == null ? Results.NotFound() : Results.Ok(cinema);
    return response;
});

app
    .AddFilmEndpoints()
    .Run();

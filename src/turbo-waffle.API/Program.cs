using turbo_waffle.API.DTO;
using turbo_waffle.Core;
using turbo_waffle.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddInfrastructrure();

var app = builder.Build();


app.MapGet("films", async (IFilmRepository filmRepository) => 
{
    var films = await filmRepository.GetAsync();
    return Results.Ok(films);
});

app.MapPost("film", async (FilmRequest filmRequest ,IFilmRepository filmRepository) => {
    var film = new Film(filmRequest.Name, filmRequest.Description, filmRequest.Author);
    await filmRepository.AddAsync(film);
});

app.Run();

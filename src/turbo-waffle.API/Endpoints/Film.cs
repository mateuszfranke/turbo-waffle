using Microsoft.AspNetCore.Mvc;
using turbo_waffle.API.DTO;
using turbo_waffle.Core;

namespace turbo_waffle.API.Endpoints
{
    internal static class Film
    {
        public static WebApplication AddFilmEndpoints(this WebApplication app)
        {

            app.MapGet("films", async (IFilmRepository filmRepository) =>
            {
                var films = await filmRepository.GetAsync();
                return Results.Ok(films);
            });

            app.MapGet("film", async (IFilmRepository filmRepository, [FromQuery] string name) =>
            {
                var film = await filmRepository.GetAsync(name);
                IResult respone = film == null ? Results.NotFound() : Results.Ok(film);
                return respone;
            });

            app.MapDelete("film", async (IFilmRepository filmRepository, [FromQuery] string name) =>
            {
                await filmRepository.DeleteAsync(name);
                return Results.NoContent();
            });

            app.MapPut("film", async (IFilmRepository filmRepository, [FromBody] FilmRequest filmRequest) =>
            {
                var film = new Core.Film(filmRequest.Name, filmRequest.Description, filmRequest.Author);
                await filmRepository.UpdateAsync(film);
                return Results.NoContent();
            });

            app.MapPost("film", async (FilmRequest filmRequest, IFilmRepository filmRepository) => {
                var film = new Core.Film(filmRequest.Name, filmRequest.Description, filmRequest.Author);
                await filmRepository.AddAsync(film);
                return Results.Ok();
            });

            app.MapGet("random-film", async (IFilmRepository filmRepository) => {

                var allFilms = await filmRepository.GetAsync();
                var randomNumber = new Random().Next(0, allFilms.Count);

                return Results.Ok(allFilms.ToArray()[randomNumber]);


            });
            return app;
        }
    }
}

using turbo_waffle.API.DTO;
using turbo_waffle.Core.Repositories;

namespace turbo_waffle.API.Endpoints;

internal static class Cinema
{
    public static WebApplication AddCinemaEndpoints(this WebApplication app)
    {
        app.MapGet("cinemas", async (ICinemaRepository repository)=> {

            var cinemas = await repository.GetAsync();
            return Results.Ok(cinemas);

        });

        app.MapGet("cinema/{id}", async (ICinemaRepository cinemaRepository, Guid id)=> {
            var cinema = await cinemaRepository.GetAsync(id);
            var response = cinema == null ? Results.NotFound() : Results.Ok(cinema);
            return response;
        });

        app.MapPost("cinema",  async (ICinemaRepository cinemaRepository, CinemaRequest request) =>
        {
            var cinema = new Core.Cinema() { City = request.City, Location = request.Location, Name = request.Name };
            await cinemaRepository.AddAsync(cinema);
        });

        return app;
    }
}
using turbo_waffle.Core.Repositories;

namespace turbo_waffle.API.Endpoints;

internal static class Repertoire
{
    public static WebApplication AddRepertoireEndpoints(this WebApplication app)
    {
        app
            .MapGet("/repositories/cinema/{id:Guid}", async (IRepertoireRepository repertoireRepository, Guid id) =>
            {
                var repertoires = await repertoireRepository.GetAsync(id);
                return Results.Ok(repertoires);
            });
            
        return app;
    }

}
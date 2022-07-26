using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using turbo_waffle.Core.Repositories;
using turbo_waffle.Infrastructure.Repositories;

[assembly: InternalsVisibleTo("turbo-waffle.API")]
namespace turbo_waffle.Infrastructure
{
    public static class Extensions
    {
        internal static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddSingleton<IFilmRepository, FilmRepository>()
                .AddSingleton<ICinemaRepository, CinemaRepository>();

            return services;
        }
    }
}

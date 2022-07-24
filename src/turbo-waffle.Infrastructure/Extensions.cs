using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using turbo_waffle.Core;

[assembly: InternalsVisibleTo("turbo-waffle.API")]
namespace turbo_waffle.Infrastructure
{
    public static class Extensions
    {
        internal static IServiceCollection AddInfrastructrure(this IServiceCollection services)
        {
            services
                .AddSingleton<IFilmRepository, FilmRepository>();

            return services;
        }
    }
}

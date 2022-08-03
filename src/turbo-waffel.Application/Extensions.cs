using MediatR;
using Microsoft.Extensions.DependencyInjection;
using turbo_waffel.Application.Queries.CinemaRepertoire;
using turbo_waffle.Core.Repositories;

namespace turbo_waffel.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services
            .AddMediatR(typeof(CinemaRepertoireQuery).Assembly);


        return services;
    }
}
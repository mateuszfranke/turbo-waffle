using System;
using MediatR;
using turbo_waffle.Core;

namespace turbo_waffel.Application.Queries.CinemaRepertoire
{
    public class CinemaRepertoireQueryHandler : IRequestHandler<CinemaRepertoireQuery, Cinema>
    {
        public async Task<Cinema> Handle(CinemaRepertoireQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}


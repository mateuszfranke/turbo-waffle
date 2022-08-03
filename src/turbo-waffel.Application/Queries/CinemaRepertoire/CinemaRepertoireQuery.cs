using System;
using MediatR;
using turbo_waffle.Core;

namespace turbo_waffel.Application.Queries.CinemaRepertoire
{
    public class CinemaRepertoireQuery :  IRequest<Cinema>
    {
        public readonly Guid _cinemaGuid;

        public CinemaRepertoireQuery(Guid cinemaGuid)
        {
            _cinemaGuid = cinemaGuid;
        }
    }
}


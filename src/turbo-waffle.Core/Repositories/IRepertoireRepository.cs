namespace turbo_waffle.Core.Repositories;

public interface IRepertoireRepository
{
    Task<IEnumerable<Repertoire>> GetAsync(Guid cinemaId);
}
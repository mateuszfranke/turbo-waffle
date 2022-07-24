using System.Runtime.CompilerServices;

namespace turbo_waffle.Core
{
    public interface IFilmRepository
    {
        Task<IReadOnlyCollection<Film>> GetAsync();
        Task AddAsync(Film film);
    }
}

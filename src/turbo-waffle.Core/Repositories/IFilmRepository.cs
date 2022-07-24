using System.Runtime.CompilerServices;

namespace turbo_waffle.Core.Repositories
{
    public interface IFilmRepository
    {
        Task<IReadOnlyCollection<Film>> GetAsync();
        Task<Film> GetAsync(string name);
        Task<Guid> AddAsync(Film film);
        Task DeleteAsync(string film);
        Task UpdateAsync(Film film);
    }
}

using System.Runtime.CompilerServices;

namespace turbo_waffle.Core
{
    public interface IFilmRepository
    {
        Task<IReadOnlyCollection<Film>> GetAsync();
        Task<Film> GetAsync(string name);
        Task AddAsync(Film film);
        Task DeleteAsync(string film);
        Task UpdateAsync(Film film);
    }
}

using turbo_waffle.Core.Repositories;

namespace turbo_waffle.Infrastructure
{
    public class FilmRepository : IFilmRepository
    {
        private readonly List<Film> Films;
        public FilmRepository()
        {
            Films = new List<Film>() {
            new("The Black Phone",
            "After being abducted by a child killer and locked in a soundproof basement," +
            " a 13-year-old boy starts receiving calls on a disconnected phone from the killer's previous victims.",
            "Scott Derrickson", Guid.Parse("8CBA018F-1EF5-4FB5-A35C-5DFCFFAB8244")),
            new("The Batman",
            "When a sadistic serial killer begins murdering key political figures in Gotham," +
            " Batman is forced to investigate the city's hidden corruption and question his family's involvement.","Matt Reeves", Guid.Parse("189BB33A-FD40-47C6-BFF0-9C404321CC6F")) };
        }

        public async Task<Guid> AddAsync(Film film)
        {
          Films.Add(film);
            return Guid.NewGuid();
        }

        public async Task DeleteAsync(string film)
        {
            var filmEntity = await GetAsync(film);
            Films.Remove(filmEntity);
        }

        public async Task<IReadOnlyCollection<Film>> GetAsync()
        {
            return await Task.FromResult(Films);
        }

        public async Task<Film> GetAsync(string name)
        {
            var film = Films.FirstOrDefault(x => x.Name == name);
            return film;
        }

        public Task UpdateAsync(Film film)
        {
            throw new NotImplementedException();
        }
    }
}

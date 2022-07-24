using turbo_waffle.Core;

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
            "Scott Derrickson"),
            new("The Batman",
            "When a sadistic serial killer begins murdering key political figures in Gotham," +
            " Batman is forced to investigate the city's hidden corruption and question his family's involvement.","Matt Reeves")

                };
        }

        public async Task AddAsync(Film film)
        {
          Films.Add(film);
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

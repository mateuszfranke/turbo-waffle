using turbo_waffle.Core.Repositories;

namespace turbo_waffle.Infrastructure
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly List<Cinema> cinemaList;
        public CinemaRepository(IFilmRepository filmRepository)
        {
            cinemaList = new List<Cinema>()
            {
                new Cinema(){
                City = "Wroclaw",
                Name = "Wroclavia",
                Location = "Sucha 1, 50-086 Wrocław",
                }
            };
        }

        public Task AddAsync(Cinema cinema)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cinema>> GetAsync()
        {
            return cinemaList;
        }
    }
}

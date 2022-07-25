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
                Id = Guid.Parse("64f65527-9ee7-4747-9970-5312c9278342")
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

        public async Task<Cinema> GetAsync(Guid id)
        {
            var cinema =  cinemaList.FirstOrDefault(x=> x.Id == id);
            return await Task.FromResult(cinema);
        }
    }
}

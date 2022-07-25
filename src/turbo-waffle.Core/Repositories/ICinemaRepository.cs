namespace turbo_waffle.Core.Repositories
{
    public interface ICinemaRepository
    {
        Task AddAsync(Cinema cinema);
        Task<IEnumerable<Cinema>> GetAsync();
        Task<Cinema> GetAsync(Guid id);
    }
}

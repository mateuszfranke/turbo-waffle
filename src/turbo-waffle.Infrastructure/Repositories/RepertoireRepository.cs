using turbo_waffle.Core.Repositories;

namespace turbo_waffle.Infrastructure.Repositories;

public class RepertoireRepository: IRepertoireRepository
{
    private List<Repertoire> repertoires;
    public RepertoireRepository()
    {
        repertoires = new List<Repertoire>();
        {
            new Repertoire() {};
        }
    }
    public async Task<IEnumerable<Repertoire>> GetAsync(Guid cinemaId)
    {
       var repertoiresForCinema = repertoires.Where(x => x.Cinema.Id == cinemaId);
       return repertoiresForCinema;
    }
}
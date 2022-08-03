namespace turbo_waffle.Core
{
    public class Cinema : Entity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public IList<Film> CurrentFilms { get; private set; }

        
    }
}

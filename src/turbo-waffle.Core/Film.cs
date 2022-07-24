namespace turbo_waffle.Core
{
    public class Film : Entity
   {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Film(string name, string description, string author, Guid id)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
        }
    }

}

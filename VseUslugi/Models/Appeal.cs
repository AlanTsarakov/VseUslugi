namespace VseUslugi.Models
{
    public class Appeal
    {
        public Appeal(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }



    }
}

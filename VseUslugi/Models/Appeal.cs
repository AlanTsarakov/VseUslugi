using System.ComponentModel.DataAnnotations;

namespace VseUslugi.Models
{
    public class Appeal
    {
        public Appeal(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }

        
        public Guid Id { get; set; }


        [Required(ErrorMessage = "Не указано имя/тема")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Не указано описание")]
        public string Description { get; set; }



    }
}

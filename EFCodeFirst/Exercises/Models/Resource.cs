using Exercises.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercises.Models
{
    public class Resource
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ResourceType ResourceType { get; set; }

        [Required]
        public string Url { get; set; }

        public Cource Course { get; set; }

        public virtual ICollection<Licence> Licences { get; set; } = new List<Licence>();
    }
}

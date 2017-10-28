using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Many_to_many.Models
{
    public class Course
    {
        [Key]
      
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    }
}

using Many_to_many.Models;
using System.Collections.Generic;

namespace Many_to_many.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Students { get; set; } = new List<Course>();
    }
}

using System;
using System.Collections.Generic;

namespace Exercises.Models
{
    public  class Cource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();

        public virtual ICollection<Resource> Resources { get; set; } = new List<Resource>();

        public virtual ICollection<Homework> HomeworkSubmissions { get; set; } = new List<Homework>();
    }
}

using System;
using System.Collections.Generic;

namespace Exercises.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Cource> Cources { get; set; } = new List<Cource>();
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_to_many.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public virtual ICollection<Employee> Employee { get; set; } = new List<Employee>();
    }
}

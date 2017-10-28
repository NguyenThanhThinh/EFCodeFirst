using System.ComponentModel.DataAnnotations.Schema;

namespace One_to_many.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}

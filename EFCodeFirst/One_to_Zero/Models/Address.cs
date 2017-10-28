using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_to_Zero.Models
{
    public class Address
    {
        [Key]
        [ForeignKey(nameof(Student))]
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual Student Student { get; set; }
    }
}

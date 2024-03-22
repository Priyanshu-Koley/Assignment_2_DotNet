using System.ComponentModel.DataAnnotations;

namespace Assignment_2_DotNet.Entities.Models
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Assignment_2_DotNet.Entities.Models
{
    public class Department
    {
        // Department Id
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        // Department name
        [Required]
        [MaxLength(50, ErrorMessage = "Length of name should be less than or equals to 50 characters")]
        public string Name { get; set; }
    }
}

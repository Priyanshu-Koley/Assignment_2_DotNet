using System.ComponentModel.DataAnnotations;

namespace Assignment_2_DotNet.Entities.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage ="Length of name should be less than or equals to 30")]
        public string? Name { get; set; }

        [Required]
        [Range(21, 100)]
        public int Age { get; set; }

        public Guid DepartmentId { get; set; }
        public Department? Department { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}

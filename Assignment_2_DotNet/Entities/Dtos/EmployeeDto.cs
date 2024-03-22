using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_2_DotNet.Entities.Dtos
{
    public class EmployeeDto
    {
        [Required]
        [MaxLength(30, ErrorMessage = "Length of name should be less than or equals to 30 characters")]
        public string Name { get; set; }
        [Required]
        [Range(21, 100, ErrorMessage ="Age should be between 21 to 100")]
        public int Age { get; set; }
        [Required]
        public Guid DepartmentId { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}

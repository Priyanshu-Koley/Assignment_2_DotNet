using System.ComponentModel.DataAnnotations;

namespace Assignment_2_DotNet.Entities.Dtos
{
    public class DepartmentDto
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Length of name should be less than or equals to 50 characters")]
        public string Name { get; set; }
    }
}

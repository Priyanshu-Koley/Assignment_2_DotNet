using System.ComponentModel.DataAnnotations;

namespace Assignment_2_DotNet.Entities.Dtos
{
    public class DepartmentDto
    {
        [Required]
        public string Name { get; set; }
    }
}

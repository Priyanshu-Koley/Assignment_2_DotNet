using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_2_DotNet.Entities.Models
{
    public class Employee
    {
        // Id
        [Key]
        public Guid Id { get; set; }

        // Employee's name
        [Required]
        [MaxLength(30, ErrorMessage = "Length of name should be less than or equals to 30 characters")]
        public string? Name { get; set; }

        // Employee's age
        [Required]
        [Range(21, 100)]
        public int Age { get; set; }


        // Employee's department Id
        [Required]
        [ForeignKey("Department")]
        public Guid DepartmentId { get; set; }

        // Reference of department table
        public Department? Department { get; set; }

        // Employee's salary
        [Required]
        public decimal Salary { get; set; }
    }
}

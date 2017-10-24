using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace employee.Models
{
    [Table("Employees")] //Create dataBase EntityFramework
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        //Input Validations
        [MaxLength(100, ErrorMessage = "Max Lenght of Name is 100.")]
        [Required(ErrorMessage = "Name must not be empty.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email must not be empty.")]
        [EmailAddress(ErrorMessage = "Must be an email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Department must not be empty.")]
        public string Department { get; set; }

    }
}
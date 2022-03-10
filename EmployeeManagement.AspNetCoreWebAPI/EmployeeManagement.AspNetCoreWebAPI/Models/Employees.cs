using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.AspNetCoreWebAPI.Models
{
    public class Employees
    {
        [Key]
        
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }
        public string Designation { get; set; }
    }
}

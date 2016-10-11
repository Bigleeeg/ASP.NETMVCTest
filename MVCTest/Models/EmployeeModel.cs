using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{  
    public class EmployeeModel
    {
        [Required(ErrorMessage ="Enter Name")]
        public string Name { get; set; }
        public string Info { get; set; }

        //[StringLength(10,ErrorMessage ="Salary length should not be greater than 10")] 
        public int Salary { get; set; }
    }

    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public string EmployeeInfo { get; set; }
        public int Salary { get; set; }
        public string SalaryColor { get; set; }
    }
}
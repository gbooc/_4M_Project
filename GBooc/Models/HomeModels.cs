using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_RIMP.Models
{
    public class EmployeeModel
    {
        //Information
        [Required]
        public string EmpID { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentID { get; set; }

        //Login
        public string LoginID { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
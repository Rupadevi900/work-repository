//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAPPEF1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="Dept Id is mandatory")]
        public int DeptId { get; set; }
        [Required(ErrorMessage ="EmpName id is mandatory")]
        public string EmpName { get; set; }
        [Required(ErrorMessage ="Employee salary is mandatory")]
        public decimal EmpSalary { get; set; }
    
        public virtual Department Department { get; set; }
    }
}

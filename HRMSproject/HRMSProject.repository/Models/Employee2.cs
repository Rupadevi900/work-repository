﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HRMSProject.repository.Models
{
    public partial class Employee2
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal EmpSalary { get; set; }
        public string EmpAddress { get; set; }
    }
}

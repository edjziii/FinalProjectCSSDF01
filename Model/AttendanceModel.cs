﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    public class AttendanceModel
    {
        public string EmployeeID { get; set;}
        public string EmployeeName { get; set; } = string.Empty;
        public string DateTime { get; set; }
        public string Status { get; set; } = "Absent";
    }
}

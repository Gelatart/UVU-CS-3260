﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{
    public class Salary : Employee
    {
        public double monthlySalary { get; set; } 
        public Salary()
        {
            empType = "Salary";
        }
        public Salary(string id, string firstN, string lastN, string fullN, double monthly) {
            empType = "Salary";
            empId = id;
            firstName = firstN;
            lastName = lastN;
            fullName = fullN;
            monthlySalary = monthly;
        }
    }
}

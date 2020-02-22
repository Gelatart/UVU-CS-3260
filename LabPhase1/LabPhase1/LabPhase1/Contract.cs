﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{
    public sealed class Contract : Employee
    {
        public double contractWage { get; set; }
        public Contract()
        {
            empType = "Contract";
        }
        public Contract(string id, string firstN, string lastN, string fullN, double wage)
        {
            empType = "Contract";
            empId = id;
            firstName = firstN;
            lastName = lastN;
            fullName = fullN;
            contractWage = wage;
        }
    }
}

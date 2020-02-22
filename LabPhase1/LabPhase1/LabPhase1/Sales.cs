using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{
    public sealed class Sales : Salary
    {
        public double commission { get; set; }
        public double grossSales { get; set; }
        public Sales()
        {
            empType = "Sales";
        }
        public Sales(string id, string firstN, string lastN, string fullN, double monthly, double comm, double gross)
        {
            empType = "Sales";
            empId = id;
            firstName = firstN;
            lastName = lastN;
            fullName = fullN;
            monthlySalary = monthly;
            commission = comm;
            grossSales = gross;
        }
    }
}

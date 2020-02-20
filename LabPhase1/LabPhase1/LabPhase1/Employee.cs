using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{
    public abstract class Employee
    {
        //public double hourlyRate { get; set; }
        public string empId { get; set; }
        public enum empType
        {
            Hourly,
            Salary,
            Sales,
            Contract
        }
        //^make its own separate, not nested?
        public string firstName { get; set; }
        public string fullName { get; set; }
        public string lastName { get; set; }
        public Employee()
        {

        }
    }
    //employee function?

    //empCounter field?
}

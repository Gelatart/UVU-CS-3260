using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{
    public class Salary : Employee
    {
        public double monthlySalary { get; set; } 
        //method for salary? +1 overl...?
        public Salary()
        {
            //why no arrow underneath?
            type = "Salary";
        }
        public Salary(id, firstN, lastN, fullN, monthly) {
            type = "Salary";
            empId = id;
            firstName = firstN;
            lastName = lastN;
            fullName = fullN;
            monthlySalary = monthly;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{
    public sealed class Hourly : Employee
    {
        public double hourlyRate { get; set; }
        public double hoursWorked { get; set; }
        //method for salary? +1 overl...?
        public Hourly()
        {
            //why no arrow underneath?
            empType = "Hourly";
        }
        public Hourly(string id, string firstN, string lastN, string fullN, double rate, double worked) 
        {
            empType = "Hourly";
            empId = id;
            firstName = firstN;
            lastName = lastN;
            fullName = fullN;
            hourlyRate = rate;
            hoursWorked = worked;
        }
    }
   //method called hourly?
}

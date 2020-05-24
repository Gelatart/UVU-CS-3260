/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_1
/// Date: 2/21/2020 10:25:00 PM
/// <summary>
/// Hourly version of the employee class
/// </summary>
///  
/// I declare that the following code was written by me or provided
/// by the instructor for this project. I understand that copying source
/// code from any other source constitutes plagiarism, and that I will receive
/// a zero on this project if I am found in violation of this policy.
/// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase3
{
    [Serializable]
    public sealed class Hourly : Employee
    {
        /// <summary>
        /// Specific values to the Hourly class
        /// </summary>
        public double hourlyRate { get; set; }
        public double hoursWorked { get; set; }

        /// <summary>
        /// Blank initialization
        /// </summary>
        public Hourly()
        {
            empType = "Hourly";
        }

        /// <summary>
        /// Proper full initialization of the Hourly class
        /// </summary>
        /// <param name="id">Id to identify in directory</param>
        /// <param name="firstN">First Name</param>
        /// <param name="lastN">Last Name</param>
        /// <param name="fullN">Full Name</param>
        /// <param name="rate">Hourly Rate</param>
        /// <param name="worked">Hours Worked</param>
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
}

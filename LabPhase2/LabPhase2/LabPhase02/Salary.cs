/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_1
/// Date: 2/21/2020 10:27:20 PM
/// <summary>
/// Salary derivation of the Employee class
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

namespace LabPhase02
{
    public class Salary : Employee
    {
        /// <summary>
        /// Unique value to the Salary class and its derivation
        /// </summary>
        public double monthlySalary { get; set; } 

        /// <summary>
        /// Blank initialization
        /// </summary>
        public Salary()
        {
            empType = "Salary";
        }
        /// <summary>
        /// Full initialization of the Salary class
        /// </summary>
        /// <param name="id">Id that identifies it in directory</param>
        /// <param name="firstN">First Name</param>
        /// <param name="lastN">Last Name</param>
        /// <param name="fullN">Full Name</param>
        /// <param name="monthly">Monthly Salary</param>
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

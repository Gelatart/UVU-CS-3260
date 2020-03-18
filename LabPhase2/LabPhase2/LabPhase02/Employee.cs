/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_1
/// Date: 2/21/2020 10:15:00 PM
/// <summary>
/// Abstract base class all other forms of employees derive from
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

    public abstract class Employee
    {
        /// <summary>
        /// The list of properties that all employee classes have
        /// </summary>
        public string empId { get; set; }
        public string empType { get; set; }
        public string firstName { get; set; }
        public string fullName { get; set; }
        public string lastName { get; set; }
        internal static int empCounter;

        /// <summary>
        /// Blank Employee initialization
        /// </summary>
        public Employee()
        {
            empType = "";
            empId = "";
            firstName = "";
            lastName = "";
            fullName = "";
        }
        /// <summary>
        /// Initialization of Employee with all the proper base elements
        /// </summary>
        /// <param name="id">The id to identify the employee</param>
        /// <param name="type">The type of worker they are</param>
        /// <param name="firstN">First Name</param>
        /// <param name="lastN">Last Name</param>
        /// <param name="fullN">Full Name</param>
        public Employee(string id, string type, string firstN, string lastN, string fullN)
        {
            empType = type;
            empId = id;
            firstName = firstN;
            lastName = lastN;
            fullName = fullN;
        }
    }
}

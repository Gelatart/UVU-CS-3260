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

namespace LabPhase3
{
    [Serializable]
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

        public string department { get; set; }
        public string title { get; set; }
        public string startDate { get; set; } //make a calendar date?
        public int benefits { get; set; } //<Potential benefits based on type
        //public SortedDictionary<string, string> Course { get; set; }
        //public SortedDictionary<string, Course> CoursesTaken { get; set; }
        //^See if can make that work?
        public SortedDictionary<string, Course> coursesTaken { get; set; }
        /*SortedDictionary<string, Course>, where the course ID is the key 
        and the value is a reference to a Course SortedDictionary
        Where should I make the separate Course SD?
        */

        public bool deleted { get; set; }
        /*Department Name
        Title
        Start Date
        Benefits
        Courses Taken/Approved
        Deleted Boolean
        */

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

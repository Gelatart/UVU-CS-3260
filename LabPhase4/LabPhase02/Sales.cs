/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_1
/// Date: 2/21/2020 10:29:00 PM
/// <summary>
/// Sales derivation of the Employee class
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
    public sealed class Sales : Salary
    {
        /// <summary>
        /// Unique values to the Sales class
        /// </summary>
        public double commission { get; set; }
        public double grossSales { get; set; }

        /// <summary>
        /// Blank initialization
        /// </summary>
        public Sales()
        {
            empType = "Sales";
        }

        /// <summary>
        /// Full initialization of the Sales class
        /// </summary>
        /// <param name="id">Id to identify in directory</param>
        /// <param name="firstN">First Name</param>
        /// <param name="lastN">Last Name</param>
        /// <param name="fullN">Full Name</param>
        /// <param name="monthly">Monthly Salary</param>
        /// <param name="comm">Commission</param>
        /// <param name="gross">Gross Sales</param>
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

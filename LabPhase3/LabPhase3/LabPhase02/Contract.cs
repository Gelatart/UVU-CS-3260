/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_1
/// Date: 2/21/2020 10:12:40 PM
/// <summary>
/// Contract version of the Employee class
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
    public sealed class Contract : Employee
    {
        /// <summary>
        /// The contract wage value
        /// </summary>
        public double contractWage { get; set; }
        /// <summary>
        /// Initialization of Contract with no extra values
        /// </summary>
        public Contract()
        {
            empType = "Contract";
        }
        /// <summary>
        /// Initialization of Contract with all the proper values
        /// </summary>
        /// <param name="id">The id to catalogue the worker for</param>
        /// <param name="firstN">First name</param>
        /// <param name="lastN">Last name</param>
        /// <param name="fullN">Full name</param>
        /// <param name="wage">Their contract wage</param>
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

/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_1
/// Date: 2/21/2020 10:25:30 PM
/// <summary>
/// The main function that creates and runs the form and tests the initial employees
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPhase02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. Loads some test driver info
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            Hourly temp = new Hourly("AA5", "Cheryl", "Kirk", "Cheryl Kirk", 3.98, 4);
            BusinessRules.AddEmployee(form1, temp);
            Contract hey = new Contract("L-1337", "John", "Chief", "John Chief", 5);
            BusinessRules.AddEmployee(form1, hey);
            Salary sup = new Salary("HAMBURGER", "Phil", "Hartman", "Phil Hartman", 7.896);
            BusinessRules.AddEmployee(form1, sup);
            Sales bro = new Sales("EMPLOYEE_ID", "David", "Lynch", "David Lynch", 4, 5.86, 387);
            BusinessRules.AddEmployee(form1, bro);
            BusinessRules.AddEmployee(form1, null);
            Application.Run(form1);
        }
    }
}

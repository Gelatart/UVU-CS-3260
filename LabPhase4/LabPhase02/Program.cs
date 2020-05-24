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

namespace LabPhase3
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
            Hourly temp2 = new Hourly("BG6", "Hayao", "Miyazaki", "Hayao Miyazaki", 7.6, 8.7);
            BusinessRules.AddEmployee(form1, temp2);
            Hourly temp3 = new Hourly("HE7", "Richard", "Marcus", "Richard Marcus", 8.56, 2);
            BusinessRules.AddEmployee(form1, temp3);
            Contract hey = new Contract("7H6", "Michael", "Jackson", "Michael Jackson", 18);
            BusinessRules.AddEmployee(form1, hey);
            Contract hey2 = new Contract("L-1337", "John", "Chief", "John Chief", 5);
            BusinessRules.AddEmployee(form1, hey2);
            Contract hey3 = new Contract("E64", "Mario", "Mario", "Mario Mario", 92);
            BusinessRules.AddEmployee(form1, hey3);
            Salary sup = new Salary("HAMBURGER", "Phil", "Hartman", "Phil Hartman", 7.896);
            BusinessRules.AddEmployee(form1, sup);
            Salary sup2 = new Salary("BACON", "George", "Costanza", "George Costanza", 82);
            BusinessRules.AddEmployee(form1, sup2);
            Salary sup3 = new Salary("EGGS", "Gordon", "Freeman", "Gordon Freeman", 11);
            BusinessRules.AddEmployee(form1, sup3);
            Sales bro = new Sales("EMPLOYEE_ID", "David", "Lynch", "David Lynch", 4, 5.86, 387);
            BusinessRules.AddEmployee(form1, bro);
            Sales bro2 = new Sales("HELLO", "George", "Lucas", "George Lucas", 3.2, 5, 3);
            BusinessRules.AddEmployee(form1, bro2);
            Sales bro3 = new Sales("HEY", "Martin", "Scorsese", "Martin Scorsese", 4.1, 5.6, 87);
            BusinessRules.AddEmployee(form1, bro3);
            BusinessRules.AddEmployee(form1, null);
            Course course1 = new Course("CS1400","Fundamentals of Programming",3,"Basic programming skills");
            BusinessRules.courseList.Add(course1.courseID,course1);
            Course course2 = new Course("CS1410", "Object Oriented Programming",3,"Intro to object-oriented concepts");
            BusinessRules.courseList.Add(course2.courseID, course2);
            Course course3 = new Course("CS3260", "C# Software Development", 3, "Introduces C# and .NET");
            BusinessRules.courseList.Add(course3.courseID, course3);
            Application.Run(form1);
        }
    }
}

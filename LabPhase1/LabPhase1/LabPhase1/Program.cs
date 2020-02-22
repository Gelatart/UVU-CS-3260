using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPhase1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
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

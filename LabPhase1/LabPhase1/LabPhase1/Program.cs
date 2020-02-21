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
            Application.Run(new Form1());
            Hourly temp = new Hourly("AA5", "Cheryl", "Kirk", "Cheryl Kirk", 3.98, 4);
            BusinessRules.AddEmployee(temp);
            Contract hey = new Contract("L-1337", "John", "Chief", "John Chief", 5);
            BusinessRules.AddEmployee(hey);
            BusinessRules.AddEmployee(null);           
        }
    }
}

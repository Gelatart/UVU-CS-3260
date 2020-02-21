using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPhase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void createEmployee() {
            string id = firstName[0] + lastName[0] + "0";
            //function that checks if id already taken?
            string type; //grab from enum
            string firstN;
            string lastN;
            string fullN = firstName + " " + lastName;
            if(type == "Hourly") {
                //hourlyRate
                //hoursWorked
                double rate;
                double worked;
                Hourly emp = new Hourly(id, firstN, lastN, fullN, rate, worked);
            } else if (type == "Salary") {
                //monthlySalary
                double monthly;
                Salary emp = new Salary(id, firstN, lastN, fullN, monthly);
            } else if (type == "Sales") {
                Sales emp = new Sales();
            } else if (type == "Contract") {
                Contract emp = new Contract();
            }
        }
    }
}

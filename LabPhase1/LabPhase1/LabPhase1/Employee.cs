using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{

    public abstract class Employee
    {
        public string empId { get; set; }
        public string empType { get; set; }
        public string firstName { get; set; }
        public string fullName { get; set; }
        public string lastName { get; set; }
        internal static int empCounter;
        public Employee()
        {
            empType = "";
            empId = "";
            firstName = "";
            lastName = "";
            fullName = "";
        }
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

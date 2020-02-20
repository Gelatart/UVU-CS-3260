using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{
    public class BusinessRules
    {
        private static BusinessRules _instance;
        public SortedDictionary<string, Employee> employeeList = new SortedDictionary<string, Employee>();
        //fields for empData and lazy?
        //methods for AddEmployee and UpdateEmployee?
        public static BusinessRules Instance
        {
            //could also getInstance() and remove get{} from inside
            get
            {
                if (_instance == null)
                {
                    _instance = new BusinessRules();
                }
                return _instance;
            }
        }

        private BusinessRules()
        {

        }
        //private int Id { get; set; } = 378591546;
        //private string Insured { get; set; } = "Mike Fillmore";

        //public string GetInsuredName() => Insured;
        //public string GetInsuredID() => Id.ToString();
    }
}

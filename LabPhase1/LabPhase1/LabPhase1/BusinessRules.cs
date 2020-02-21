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
        
        public void AddEmployee(Employee emp) {
            //handle null references without errors!
            //simple employee ID, generated from input?
            //indexer to iterate through sortedDict
            //Your driver program (main) needs to populate the directory and then to read from it and display the data.  
            //You create test employees for this.
            //Do not implement any indexing or additional functionality in the Employee Classes
            string id = emp.empId;
            employeeList.add(id,emp);
        }
        
        public void UpdateEmployee(Employee emp) {
            foreach (KeyValuePair<string, Employee> worker in employeeList) {
                if(emp.empId == worker.value.empId) {
                    worker.value = emp;
                    break;
                }
            }
        }
        //private int Id { get; set; } = 378591546;
        //private string Insured { get; set; } = "Mike Fillmore";

        //public string GetInsuredName() => Insured;
        //public string GetInsuredID() => Id.ToString();
        /*
        Create a BusinessRules class  (Singleton class)
        This class needs to contain a SortedDictionary<string, Employee>; where string is the employee ID and Employee is a reference 
        to an employee object or null. Make sure your SortedDictionary<Tk, Tv> will be able to handle null references without errors!
        The Employee ID can be any string combination you wish, but, its implementation will be changed in a future enhancement; so, 
        don't do some crazy implementation.
        Make sure you are able to retrieve Employee object references to/from this container; which means that you will need to be 
        able to iterate through the employee objects, so make sure that you have an indexer that works with the SortedDictionary<Tk, Tv>. 
        Your driver program (main) needs to populate the directory and then to read from it and display the data.  You create 
        test employees for this.
        Add any additional Properties, Fields, Methods, or Indexers you need to make the BusinessRules Class to work properly. Do not 
        implement any indexing or additional functionality in the Employee Classes. It will only make your project harder later.  
        Remember to follow good programming principles and do not over-complicate your methods or purpose of your BusinessRules Class.
        
        Allow the user to input Employee data (First Name, Last Name, Type (Hourly, Salary, Sales, Contract)).
        Depending on the employee type, only show certain fields that meet the requirements of each type, such as:
        Hourly: Show only the Hourly Rate and Hours Worked fields.
        Salary: Show only the Monthly Salary field.
        Sales: Show only the Monthly Salary, Commission, and Gross Sales fields.
        Contract: Show only the Contract Wage field.
        2.) Create Employee Objects and keep track of them in your Singleton BusinessClass dictionary. Implement the ability to 
        display all of the employees and their data by using the references contained in the BusinessRules class.
 
        */
    }
}

/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_1
/// Date: 2/21/2020 10:10:10 PM
/// <summary>
///Singleton class that adds employees to the SortedDictionary and updates their data
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

namespace LabPhase02
{
    /// <summary>
    /// Sets it up as a singleton class
    /// </summary>
    public class BusinessRules
    {
        private static BusinessRules _instance;
        public static SortedDictionary<string, Employee> employeeList = new SortedDictionary<string, Employee>();
        public static BusinessRules Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BusinessRules();
                }
                return _instance;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public Employee this [string id]
        {
            //UPDATE OLD CODE TO REFLECT THIS NEW INDEXER?
            get { return employeeList[id]; }
            set { employeeList[id] = value; }
        }

        private BusinessRules()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        
        public static string findNullID() {
                string id = "BLANK-";
                Random random = new Random();
                int randomNumber = random.Next(0, 1000);
                id = id + randomNumber;
                bool isUnique = false;
                while (!isUnique)
                {
                    int counted = 0;
                    foreach (KeyValuePair<string, Employee> worker in employeeList)
                    {
                        counted++;
                        if(worker.Key == id)
                        {
                            id = "BLANK-";
                            Random random2 = new Random();
                            int randomNumber2 = random.Next(0, 1000);
                            id = id + randomNumber;
                            break;
                        }
                    }
                    if(counted == employeeList.Count)
                    {
                        isUnique = true;
                    }
                }
                return id;
        }
        
        /// <summary>
        /// Adds employees or null references to the directory
        /// </summary>
        /// <param name="form1">The Form1 that controls the Windows Form where the ViewList will be populated</param>
        /// <param name="emp">Employee passed in that is being added to the directory</param>
        /// <returns></returns>
        
        public static string AddEmployee(Form1 form1, Employee emp) {
            //indexer to iterate through sortedDict
            string id;
            if (emp == null)
            {
                id = findNullID();
            } else
            {
                id = emp.empId;
            }
            try {
                employeeList.Add(id,emp); //argumentexception id already added
                //try if exception make new id for it and try again
                Employee.empCounter++;
                form1.populateItem(id);
            }
            catch (ArgumentException) {
                
            }
            
            return id;
        }

        /// <summary>
        /// Updates an already existing employee in the database with new information
        /// </summary>
        /// <param name="emp">The Employee that is passed in</param>
        public static void UpdateEmployee(Employee emp)
        {
            foreach (KeyValuePair<string, Employee> worker in employeeList) {
                try
                {
                    if (emp.empId == worker.Value.empId)
                    {
                        employeeList[worker.Value.empId] = emp;
                        break;
                    }
                } catch (NullReferenceException)
                {

                }
                
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public static List<Employee> SearchEmployeeID(string empId)
        {
            Employee emp;
            List<Employee> empList = new List<Employee>();
            foreach (KeyValuePair<string, Employee> worker in employeeList)
            {
                
                try
                {
                    if(worker.Value.empId.StartsWith(empId))
                    {
                        empList.Add(worker.Value);
                    }
                }
                catch (NullReferenceException)
                {

                }
              
            }    
           
            return empList;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public static List<Employee> SearchEmployeeFirst(string firstName)
        {
            List<Employee> empList = new List<Employee>();
            foreach (KeyValuePair<string, Employee> worker in employeeList)
            {

                try
                {
                    if (worker.Value.firstName.StartsWith(firstName))
                    {
                        empList.Add(worker.Value);
                    }
                }
                catch (NullReferenceException)
                {

                }

            }
            return empList;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public static List<Employee> SearchEmployeeLast(string lastName)
        {
            List<Employee> empList = new List<Employee>();
            foreach (KeyValuePair<string, Employee> worker in employeeList)
            {

                try
                {
                    if (worker.Value.lastName.StartsWith(lastName))
                    {
                        empList.Add(worker.Value);
                    }
                }
                catch (NullReferenceException)
                {

                }

            }
            return empList;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static List<Employee> SearchEmployeeFull(string fullName)
        {
            List<Employee> empList = new List<Employee>();
            foreach (KeyValuePair<string, Employee> worker in employeeList)
            {

                try
                {
                    if (worker.Value.fullName.StartsWith(fullName))
                    {
                        empList.Add(worker.Value);
                    }
                }
                catch (NullReferenceException)
                {

                }

            }
            return empList;

        }
    }
}

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

namespace LabPhase1
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

        private BusinessRules()
        {

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
                id = "BLANK-";
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
            } else
            {
                id = emp.empId;
            }      
            employeeList.Add(id,emp);
            Employee.empCounter++;
            form1.populateItem(id);
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
       
    }
}

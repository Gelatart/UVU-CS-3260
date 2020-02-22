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

        public static void UpdateEmployee(Employee emp)
        {
            foreach (KeyValuePair<string, Employee> worker in employeeList) {
                if(emp.empId == worker.Value.empId) {
                    employeeList[worker.Value.empId] = emp;
                    break;
                }
            }

        }
       
    }
}

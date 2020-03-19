/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_2
/// Date: 3/15/2020 11:57:00 PM
/// <summary>
/// Unit Tests to test out that all the different functions are working as intended
/// </summary>
///  
/// I declare that the following code was written by me or provided
/// by the instructor for this project. I understand that copying source
/// code from any other source constitutes plagiarism, and that I will receive
/// a zero on this project if I am found in violation of this policy.
/// ---------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabPhase02;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// A Red Test for testing the Salary class
        /// </summary>
        [TestMethod]
        public void RedSalaryTestMethod()
        {
            //Arrange
            string empId = "";
            string firstName = "";
            string lastName = "";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            //Act
            string fullN = emp.fullName;
            //Assert
            Assert.AreEqual("Steven Bishop", fullN);
        }
        /// <summary>
        /// A Green Test for testing the Salary class
        /// </summary>
        [TestMethod]
        public void GreenSalaryTestMethod()
        {
            //Arrange
            string empId = "";
            string firstName = "";
            string lastName = "";
            string fullName = "Steven Bishop";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            //Act
            string fullN = emp.fullName;
            //Assert
            Assert.AreEqual("Steven Bishop", fullN);
        }
        /// <summary>
        /// A Red Test for testing the Contract class
        /// </summary>
        [TestMethod]
        public void RedContractTestMethod()
        {
            //Arrange
            string empId = "";
            string firstName = "";
            string lastName = "";
            string fullName = "";
            double wage = 1;
            Contract emp = new Contract(empId, firstName, lastName, fullName, wage);
            //Act
            string fullN = emp.fullName;
            //Assert
            Assert.AreEqual("Richard Wilson", fullN);
        }
        /// <summary>
        /// A Green Test for testing the Contract class
        /// </summary>
        [TestMethod]
        public void GreenContractTestMethod()
        {
            //Arrange
            string empId = "";
            string firstName = "";
            string lastName = "";
            string fullName = "Richard Wilson";
            double wage = 1;
            Contract emp = new Contract(empId, firstName, lastName, fullName, wage);
            //Act
            string fullN = emp.fullName;
            //Assert
            Assert.AreEqual("Richard Wilson", fullN);
        }
        /// <summary>
        /// A Red Test for testing the Hourly class
        /// </summary>
        [TestMethod]
        public void RedHourlyTestMethod()
        {
            //Arrange
            string empId = "";
            string firstName = "";
            string lastName = "";
            string fullName = "";
            double rate = 1;
            double worked = 1;
            Hourly emp = new Hourly(empId, firstName, lastName, fullName, rate, worked);
            //Act
            string fullN = emp.fullName;
            //Assert
            Assert.AreEqual("Kevin Urquhart", fullN);
        }
        /// <summary>
        /// A Green Test for testing the Hourly class
        /// </summary>
        [TestMethod]
        public void GreenHourlyTestMethod()
        {
            //Arrange
            string empId = "";
            string firstName = "";
            string lastName = "";
            string fullName = "Kevin Urquhart";
            double rate = 1;
            double worked = 1;
            Hourly emp = new Hourly(empId, firstName, lastName, fullName, rate, worked);
            //Act
            string fullN = emp.fullName;
            //Assert
            Assert.AreEqual("Kevin Urquhart", fullN);
        }
        /// <summary>
        /// A Red Test for testing the Sales class
        /// </summary>
        [TestMethod]
        public void RedSalesTestMethod()
        {
            //Arrange
            string empId = "";
            string firstName = "";
            string lastName = "";
            string fullName = "";
            double monthly = 1;
            double comm = 1;
            double gross = 1;
            Sales emp = new Sales(empId, firstName, lastName, fullName, monthly, comm, gross);
            //Act
            string fullN = emp.fullName;
            //Assert
            Assert.AreEqual("Brian Tsao", fullN);
        }
        /// <summary>
        /// A Green Test for testing the Sales class
        /// </summary>
        [TestMethod]
        public void GreenSalesTestMethod()
        {
            //Arrange
            string empId = "";
            string firstName = "";
            string lastName = "";
            string fullName = "Brian Tsao";
            double monthly = 1;
            double comm = 1;
            double gross = 1;
            Sales emp = new Sales(empId, firstName, lastName, fullName, monthly, comm, gross);
            //Act
            string fullN = emp.fullName;
            //Assert
            Assert.AreEqual("Brian Tsao", fullN);
        }
        /// <summary>
        /// A Red Test for testing the BusinessRules class's employeeList
        /// </summary>
        [TestMethod]
        public void RedBusinessTestMethod()
        {
            //Arrange
            Form1 form1 = new Form1();
            string empId = "101";
            //string tempId = "343";
            string firstName = "";
            string lastName = "";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            //Salary temp = new Salary(tempId, firstName, lastName, fullName, monthly);
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            //Assert
            Employee empRep = BusinessRules.employeeList[empId];
            Assert.AreEqual(empRep.empId, "343");
        }
        /// <summary>
        /// A Green Test for testing the BusinessRules class's employeeList
        /// </summary>
        [TestMethod]
        public void GreenBusinessTestMethod()
        {
            //Arrange
            Form1 form1 = new Form1();
            string empId = "101";
            string tempId = empId;
            string firstName = "";
            string lastName = "";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Salary temp = new Salary(tempId, firstName, lastName, fullName, monthly);
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            //Assert
            Employee empRep = BusinessRules.employeeList[empId];
            Assert.AreEqual(empRep.empId, temp.empId);
        }
        /// <summary>
        /// A Red Test for testing the search by ID method
        /// </summary>
        [TestMethod]
        public void RedSearchIDTestMethod()
        {
            //Arrange
            string empId = "301";
            string firstName = "";
            string lastName = "";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            List<Employee> temp = BusinessRules.SearchEmployeeID(empId);
            //Assert
            Assert.AreEqual(temp[0].empId, "801");
        }
        /// <summary>
        /// A Green Test for testing the search by ID method
        /// </summary>
        [TestMethod]
        public void GreenSearchIDTestMethod()
        {
            //Arrange
            string empId = "301";
            string firstName = "";
            string lastName = "";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            List<Employee> temp = BusinessRules.SearchEmployeeID(empId);
            //Assert
            Assert.AreEqual(temp[0].empId, emp.empId);
        }
        /// <summary>
        /// A Red Test for testing the search by First Name method
        /// </summary>
        [TestMethod]
        public void RedSearchFirstTestMethod()
        {
            //Arrange
            string empId = "301";
            string firstName = "George";
            string lastName = "";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            List<Employee> temp = BusinessRules.SearchEmployeeFirst(firstName);
            //Assert
            Assert.AreEqual(temp[0].firstName, "Robert");
        }
        /// <summary>
        /// A Green Test for testing the search by First Name method
        /// </summary>
        [TestMethod]
        public void GreenSearchFirstTestMethod()
        {
            //Arrange
            string empId = "301";
            string firstName = "George";
            string lastName = "";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            List<Employee> temp = BusinessRules.SearchEmployeeFirst(firstName);
            //Assert
            Assert.AreEqual(temp[0].firstName, emp.firstName);
        }
        /// <summary>
        /// A Red Test for testing the search by Last Name method
        /// </summary>
        [TestMethod]
        public void RedSearchLastTestMethod()
        {
            //Arrange
            string empId = "301";
            string firstName = "";
            string lastName = "Wilson";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            List<Employee> temp = BusinessRules.SearchEmployeeLast(lastName);
            //Assert
            Assert.AreEqual(temp[0].lastName, "Richards");
        }
        /// <summary>
        /// A Green Test for testing the search by Last Name method
        /// </summary>
        [TestMethod]
        public void GreenSearchLastTestMethod()
        {
            //Arrange
            string empId = "301";
            string firstName = "";
            string lastName = "Wilson";
            string fullName = "";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            List<Employee> temp = BusinessRules.SearchEmployeeLast(lastName);
            //Assert
            Assert.AreEqual(temp[0].lastName, emp.lastName);
        }
        /// <summary>
        /// A Red Test for testing the search by Full Name method
        /// </summary>
        [TestMethod]
        public void RedSearchFullTestMethod()
        {
            //Arrange
            string empId = "301";
            string firstName = "";
            string lastName = "";
            string fullName = "Richard Wilson";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            List<Employee> temp = BusinessRules.SearchEmployeeFull(fullName);
            //Assert
            Assert.AreEqual(temp[0].fullName, "Mr. Rogers");
        }
        /// <summary>
        /// A Green Test for testing the search by Full Name method
        /// </summary>
        [TestMethod]
        public void GreenSearchFullTestMethod()
        {
            //Arrange
            string empId = "301";
            string firstName = "";
            string lastName = "";
            string fullName = "Richard Wilson";
            double monthly = 1;
            Salary emp = new Salary(empId, firstName, lastName, fullName, monthly);
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            //Act
            BusinessRules.AddEmployee(form1, emp);
            List<Employee> temp = BusinessRules.SearchEmployeeFull(fullName);
            //Assert
            Assert.AreEqual(temp[0].fullName, emp.fullName);
        }
        [TestMethod]
        public void TextChangedMethod()
        {
            //Arrange
            Form1 form1 = new Form1();
            BusinessRules.employeeList.Clear();
            ListView ListView1 = new ListView();
            ListView ListView2 = new ListView();        
            Hourly temp = new Hourly("AA5", "Cheryl", "Kirk", "Cheryl Kirk", 3.98, 4);
            BusinessRules.AddEmployee(form1, temp);
            Contract hey = new Contract("L-1337", "John", "Chief", "John Chief", 5);
            BusinessRules.AddEmployee(form1, hey);
            Salary sup = new Salary("HAMBURGER", "Phil", "Hartman", "Phil Hartman", 7.896);
            BusinessRules.AddEmployee(form1, sup);
            Sales bro = new Sales("EMPLOYEE_ID", "David", "Lynch", "David Lynch", 4, 5.86, 387);
            BusinessRules.AddEmployee(form1, bro);
            form1.comboBox2.SelectedItem = "Full Name";


            //Act
            form1.textBox7.Text += "D";
            ListView1 = form1.searchEmployees();
            ListView2.Items.Add(bro.fullName);

            //Assert
            Assert.AreEqual(ListView1.Items[0].ToString(),ListView2.Items[0].ToString());
        }
    }
}

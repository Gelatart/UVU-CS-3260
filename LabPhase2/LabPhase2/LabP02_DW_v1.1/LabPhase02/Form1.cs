/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_Phase_1
/// Date: 3/18/2020 10:56:05 PM
/// <summary>
/// Form where users can add employees/null references, and update existing entries
/// </summary>
///  
/// I declare that the following code was written by me or provided
/// by the instructor for this project. I understand that copying source
/// code from any other source constitutes plagiarism, and that I will receive
/// a zero on this project if I am found in violation of this policy.
/// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPhase02
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes all the form components, and prints out any worker alredy listed in the employee directory in the ViewList
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            foreach (KeyValuePair<string, Employee> worker in BusinessRules.employeeList)
            {
                listView1.Items.Add(worker.Value.fullName);
            }
            this.textBox7.TextChanged += new EventHandler(this.textBox7_TextChanged);

        }

        /// <summary>
        /// Validates if the type of worker has been selected
        /// </summary>
        /// <returns>Returns if selected or not</returns>

        public bool validateType()
        {
            try
            {
                Object selectedItem = comboBox1.SelectedItem;
                string type = selectedItem.ToString();
                errorProvider1.SetError(labelError, null);
                return true;
            }
            catch (NullReferenceException)
            {
                errorProvider1.SetError(labelError, "Need to select a type!");
                return false;
            }
        }

        /// <summary>
        /// Validates whether there is text in the name fields or not to extract data from
        /// </summary>
        /// <returns>Returns if there was text in them or not</returns>

        public bool validateText()
        {
            try
            {
                string firstN = textBox1.Text;
                string lastN = textBox2.Text;
                char first = firstN[0];
                char second = lastN[0];
                errorProvider1.SetError(labelError, null);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        /// <summary>
        /// Creates a new employee object from data that has been entered into the forms
        /// </summary>
        /// <returns>Returns the employee object or a null reference</returns>

        public Employee createEmployee()
        {
            bool ifBegin = validateText();
            if (ifBegin)
            {
                Employee emp;
                string firstN = textBox1.Text;
                string lastN = textBox2.Text;
                Object selectedItem = comboBox1.SelectedItem;
                string type = selectedItem.ToString();

                char a = firstN[0];
                char b = lastN[0];
                string id = a + b + "-";
                Random random = new Random();
                int randomNumber = random.Next(0, 1000);
                id = id + randomNumber;
                string fullN = firstN + " " + lastN;
                if (type == "Hourly")
                {
                    double rate = Double.Parse(textBox4.Text);
                    double worked = Double.Parse(textBox5.Text);
                    Hourly temp = new Hourly(id, firstN, lastN, fullN, rate, worked);
                    emp = temp;
                    Employee.empCounter++;
                    return temp;
                }
                else if (type == "Salary")
                {
                    double monthly = Double.Parse(textBox4.Text);
                    Salary temp = new Salary(id, firstN, lastN, fullN, monthly);
                    emp = temp;
                    Employee.empCounter++;
                    return temp;
                }
                else if (type == "Sales")
                {
                    double monthly = Double.Parse(textBox4.Text);
                    double comm = Double.Parse(textBox5.Text);
                    double gross = Double.Parse(textBox6.Text);
                    Sales temp = new Sales(id, firstN, lastN, fullN, monthly, comm, gross);
                    emp = temp;
                    Employee.empCounter++;
                    return temp;
                }
                else if (type == "Contract")
                {
                    double wage = Double.Parse(textBox4.Text);
                    Contract temp = new Contract(id, firstN, lastN, fullN, wage);
                    emp = temp;
                    Employee.empCounter++;
                    return temp;
                }
                Employee.empCounter++;
                return null;
            }
            else
            {
                Employee.empCounter++;
                return null;
            }

        }

        /// <summary>
        /// Button click event, that clears the fields to prepare for the addition of a new employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox4.Visible = false;
            label6.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
            label8.Visible = false;
            comboBox1.SelectedIndex = -1;
            listView1.SelectedItems.Clear();
            errorProvider1.SetError(labelError, null);
        }

        /// <summary>
        /// Combo Box selection change event, that sees if something has been selected and what fields to bring up if so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            if (selectedItem == null)
            {
                textBox4.Visible = false;
                label6.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
            }
            else if (selectedItem.ToString() == "Hourly")
            {
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
                label7.Visible = true;
                textBox6.Visible = false;
                label8.Visible = false;
                label6.Text = "Hourly Rate";
                label7.Text = "Hours Worked";
            }
            else if (selectedItem.ToString() == "Salary")
            {
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
                label6.Text = "Monthly Salary";
            }
            else if (selectedItem.ToString() == "Sales")
            {
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
                label7.Visible = true;
                textBox6.Visible = true;
                label8.Visible = true;
                label6.Text = "Monthly Salary";
                label7.Text = "Commission";
                label8.Text = "Gross Sales";
            }
            else if (selectedItem.ToString() == "Contract")
            {
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
                label6.Text = "Contract Wage";
            }
        }

        /// <summary>
        /// List View selection event, that checks to see if another item has been selected into the list view to change what Employee's data to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(labelError, null);
            if (listView1.SelectedItems.Count == 0)
                return;
            if (listView1.SelectedItems[0].Text.Contains("BLANK"))
            {
                textBox1.Text = "NULL";
                textBox2.Text = "NULL";
                textBox3.Text = listView1.SelectedItems[0].Text;
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox4.Visible = false;
                label6.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                foreach (KeyValuePair<string, Employee> worker in BusinessRules.employeeList)
                {
                    try
                    {
                        if (worker.Value.fullName == listView1.SelectedItems[0].Text)
                        {
                            Employee emp = worker.Value;
                            textBox1.Text = emp.firstName;
                            textBox2.Text = emp.lastName;
                            textBox3.Text = emp.empId;
                            if (emp.empType == "Hourly")
                            {
                                Hourly temp = (Hourly)emp;
                                textBox4.Visible = true;
                                label6.Visible = true;
                                textBox5.Visible = true;
                                label7.Visible = true;
                                textBox6.Visible = false;
                                label8.Visible = false;
                                textBox4.Text = temp.hourlyRate.ToString();
                                textBox5.Text = temp.hoursWorked.ToString();
                                comboBox1.SelectedItem = "Hourly";
                            }
                            else if (emp.empType == "Salary")
                            {
                                Salary temp = (Salary)emp;
                                textBox4.Visible = true;
                                label6.Visible = true;
                                textBox5.Visible = false;
                                label7.Visible = false;
                                textBox6.Visible = false;
                                label8.Visible = false;
                                textBox4.Text = temp.monthlySalary.ToString();
                                comboBox1.SelectedItem = "Salary";
                            }
                            else if (emp.empType == "Sales")
                            {
                                Sales temp = (Sales)emp;
                                textBox4.Visible = true;
                                label6.Visible = true;
                                textBox5.Visible = true;
                                label7.Visible = true;
                                textBox6.Visible = true;
                                label8.Visible = true;
                                textBox4.Text = temp.monthlySalary.ToString();
                                textBox5.Text = temp.commission.ToString();
                                textBox6.Text = temp.grossSales.ToString();
                                comboBox1.SelectedItem = "Sales";
                            }
                            else if (emp.empType == "Contract")
                            {
                                Contract temp = (Contract)emp;
                                textBox4.Visible = true;
                                label6.Visible = true;
                                textBox5.Visible = false;
                                label7.Visible = false;
                                textBox6.Visible = false;
                                label8.Visible = false;
                                textBox4.Text = temp.contractWage.ToString();
                                comboBox1.SelectedItem = "Contract";
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// Validates whether submission were proper double values for the employee classes
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public bool validateSubmit(string input)
        {
            double submission;
            try
            {
                submission = Double.Parse(input);
                errorProvider1.SetError(labelError, null);
                return true;
            }
            catch (FormatException)
            {
                errorProvider1.SetError(labelError, "Not proper double value!");
                return false;
            }
        }

        /// <summary>
        /// Populates an item in the ListView based on what Employee matches the id given
        /// </summary>
        /// <param name="id"></param>

        public void populateItem(string id)
        {
            Employee emp = BusinessRules.employeeList[id];
            if (emp == null)
            {
                listView1.Items.Add(id);
            }
            else
            {
                listView1.Items.Add(emp.fullName);
            }
        }

        /// <summary>
        /// Button that checks if the conditions are right to either add or update an employee in the directory and properly display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            bool ifContinue = validateType();
            if (ifContinue)
            {
                bool v1 = true;
                bool v2 = true;
                bool v3 = true;
                if (textBox4.Visible == true)
                {
                    v1 = validateSubmit(textBox4.Text);
                }
                if (textBox5.Visible == true)
                {
                    v2 = validateSubmit(textBox5.Text);
                }
                if (textBox6.Visible == true)
                {
                    v3 = validateSubmit(textBox6.Text);
                }
                if (v1 && v2 && v3)
                {
                    if (listView1.SelectedItems.Count > 0)
                    {
                        string id = textBox3.Text;
                        Employee newEmp = createEmployee();
                        newEmp.empId = id;
                        try
                        {
                            BusinessRules.UpdateEmployee(newEmp);
                            listView1.SelectedItems[0].Text = newEmp.fullName;
                            errorProvider1.SetError(labelError, null);
                        }
                        catch (NullReferenceException)
                        {
                            errorProvider1.SetError(labelError, "Can't update a null employee!");
                        }
                    }
                    else
                    {
                        Employee newEmp = createEmployee();
                        string id = BusinessRules.AddEmployee(this, newEmp);

                        int i = listView1.Items.Count - 1;
                        listView1.Items[i].Selected = true;
                    }
                }
            }


        }
        /// <summary>
        /// Method that acts when text has been changed in the search box, reloads entire employee list if text box is empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox7.Text))
            {
                listView1.Clear();
                label9.Visible = false;
                foreach (KeyValuePair<string, Employee> worker in BusinessRules.employeeList)
                {
                    try
                    {
                        listView1.Items.Add(worker.Value.fullName);
                        //BusinessRules.AddEmployee(this, worker.Value);
                    } catch (NullReferenceException)
                    {
                        //BusinessRules.AddEmployee(this, null);
                        //properly add the null employee to listview
                        listView1.Items.Add(BusinessRules.findNullID());
                        continue;
                    }
                    
                }
            } else
            {
                searchEmployees();
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /// <summary>
        /// Method that searches for employees based on the criteria and lists them in the list view
        /// </summary>
        /// <returns>The updated ListView</returns>
        public ListView searchEmployees()
        {

            Object selectedItem = comboBox2.SelectedItem;
            if (selectedItem == null)
            {
                label9.Text = "Need to set type!";
                label9.Visible = true;
            }
            else if (selectedItem.ToString() == "ID")
            {
                
                List<Employee> temp = BusinessRules.SearchEmployeeID(textBox7.Text);
                updateList(temp);


            }
            else if (selectedItem.ToString() == "First Name")
            {
                List<Employee> temp = BusinessRules.SearchEmployeeFirst(textBox7.Text);
                updateList(temp);
            }
            else if (selectedItem.ToString() == "Last Name")
            {
                List<Employee> temp = BusinessRules.SearchEmployeeLast(textBox7.Text);
                updateList(temp);
            }
            else if (selectedItem.ToString() == "Full Name")
            {
                List<Employee> temp = BusinessRules.SearchEmployeeFull(textBox7.Text);
                updateList(temp);
            }
            return listView1;
        }
        /// <summary>
        /// Method that updates the ListView
        /// </summary>
        /// <param name="temp">Temporary employee file that is passed in</param>
        public void updateList(List<Employee> temp)
        {
            //refactored from previous duplication into its own method
            listView1.Clear();
            if (temp.Count == 0)
            {
                label9.Text = "No Employees Found";
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
                foreach (Employee worker in temp)
                {
                    listView1.Items.Add(worker.fullName);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//OBJECTIVES: Successfully handle null reference to sorteddictionary without errors
//Full error checking/recovery?
//Input properly vetted?
//Proper UML hierarchy?
//Proper test employees in main function to populate, read, and display
//Proper indexer for dictionary?

namespace LabPhase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (KeyValuePair<string, Employee> worker in BusinessRules.employeeList)
            {
                listView1.Items.Add(worker.Value.fullName);
                //Console.WriteLine(worker.Key);
                //Console.WriteLine(worker.Value.fullName);
                //textBox3.Text += BusinessRules.employeeList[worker.Key];
            }
                
        }

        /*public int checkId(string potential, int result)
        {
            //int result = 0;
            foreach (KeyValuePair<string, Employee> worker in BusinessRules.employeeList)
            {
                if(worker.Key == potential + result)
                {
                    int newResult = result++;
                    checkId(potential, newResult);
                }
            }
            return result;
        }*/

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
                errorProvider1.SetError(labelError, "Need to input text for the names!");
                return false;
            }
        }
        
        public Employee createEmployee() {
            //Employee emp = new Employee();
            bool ifBegin = validateText();
            if(ifBegin)
            {
                Employee emp;
                string firstN = textBox1.Text;
                string lastN = textBox2.Text;
                Object selectedItem = comboBox1.SelectedItem;
                string type = selectedItem.ToString();

                //set to get from enum?
                char a = firstN[0];
                char b = lastN[0];
                string id = a + b + "-";
                int result = 0;
                //result = checkId(id, result);
                Random random = new Random();
                int randomNumber = random.Next(0, 1000);
                id = id + randomNumber;
                //function that checks if id already taken?
                //string type; //grab from enum
                string fullN = firstN + " " + lastN;
                //string id = fullN;
                if (type == "Hourly")
                {
                    //hourlyRate
                    //hoursWorked
                    double rate = Double.Parse(textBox4.Text);
                    double worked = Double.Parse(textBox5.Text);
                    Hourly temp = new Hourly(id, firstN, lastN, fullN, rate, worked);
                    emp = temp;
                    Employee.empCounter++;
                    return temp;
                }
                else if (type == "Salary")
                {
                    //monthlySalary
                    double monthly = Double.Parse(textBox4.Text);
                    Salary temp = new Salary(id, firstN, lastN, fullN, monthly);
                    emp = temp;
                    Employee.empCounter++;
                    return temp;
                }
                else if (type == "Sales")
                {
                    //commission
                    //grossSales
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
                    //contractWage
                    double wage = Double.Parse(textBox4.Text);
                    Contract temp = new Contract(id, firstN, lastN, fullN, wage);
                    emp = temp;
                    Employee.empCounter++;
                    return temp;
                }
                //Employee.empCounter++;
                //popup box, businessrules addEmployee, select newly created item in list
                //return emp;
                return null;
            } else
            {
                return null;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set it to be working on new employee?
            //clear employee-specific fields
            //clear all values
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
            //combobox 1 clear
        }

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
                //hourly rate, hours worked
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
                label7.Visible = true;
                textBox6.Visible = false;
                label8.Visible = false;
                label6.Text = "Hourly Rate";
                label7.Text = "Hours Worked";
            } else if (selectedItem.ToString() == "Salary")
            {
                //monthly salary
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
                label6.Text = "Monthly Salary";
            } else if (selectedItem.ToString() == "Sales")
            {
                //monthly salary, commission, gross sales
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
                label7.Visible = true;
                textBox6.Visible = true;
                label8.Visible = true;
                label6.Text = "Monthly Salary";
                label7.Text = "Commission";
                label8.Text = "Gross Sales";
            } else if (selectedItem.ToString() == "Contract")
            {
                //contract wage
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
                label6.Text = "Contract Wage";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display attributes of employee in field, now can update that employee
            if (listView1.SelectedItems.Count == 0)
                return;
            foreach (KeyValuePair<string, Employee> worker in BusinessRules.employeeList)
            {
                if(worker.Value.fullName == listView1.SelectedItems[0].Text)
                {
                    Employee emp = worker.Value;
                    textBox1.Text = emp.firstName;
                    textBox2.Text = emp.lastName;
                    textBox3.Text = emp.empId;
                    if (emp.empType == "Hourly")
                    {
                        Hourly temp =  (Hourly)emp;
                        //hourly rate, hours worked
                        textBox4.Visible = true;
                        label6.Visible = true;
                        textBox5.Visible = true;
                        label7.Visible = true;
                        textBox6.Visible = false;
                        label8.Visible = false;
                        //Hourly temp = emp;
                        textBox4.Text = temp.hourlyRate.ToString();
                        textBox5.Text = temp.hoursWorked.ToString();
                        comboBox1.SelectedItem = "Hourly";
                    }
                    else if (emp.empType == "Salary")
                    {
                        Salary temp = (Salary)emp;
                        //monthly salary
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
                        //monthly salary, commission, gross sales
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
                        //contract wage
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
        }

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
                //textBoxReal.Text = $"INVALID INPUT";
                //textBoxImag.Text = $"INVALID INPUT";
                errorProvider1.SetError(labelError, "Not proper double value!");
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            //string type = selectedItem.ToString();
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
                    //if selected list item, call update, otherwise add
                    if (listView1.SelectedItems.Count > 0)
                    {
                        // Do something
                        string id = textBox3.Text;
                        Employee newEmp = createEmployee();
                        newEmp.empId = id;
                        BusinessRules.UpdateEmployee(newEmp);
                    }
                    else
                    {
                        Employee newEmp = createEmployee();
                        BusinessRules.AddEmployee(newEmp);
                        listView1.Items.Add(newEmp.fullName);
                        int i = listView1.Items.Count - 1;
                        listView1.Items[i].Selected = true;
                        //NEED TO DO: Be able to pass in null reference
                    }
                }
            }
            
            
        }
    }
}

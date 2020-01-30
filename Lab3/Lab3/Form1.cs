/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_03
/// Date: 1/24/2020 11:37:25 PM
/// <summary>
/// This is a form that allows you to either display all data types' max and min values, or individual ones, depending on which form you go to.
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

namespace Lab3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The form is initalized here
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If I click this button, it takes me to the form for all data types
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        /// <summary>
        /// If I click this button, it takes me to the form where I select which individual data type I look at
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}

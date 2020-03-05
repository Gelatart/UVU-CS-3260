/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_06
/// Date: 3/1/2020 11:43:00 PM
/// <summary>
/// Form1 where all the results will be displayed
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

namespace Lab6
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes the form and creates the TestDelegate that tests will be run with
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Text = "";
            TestDelegate td = new TestDelegate();
            td.RunTests(this);
        }
        
        /// <summary>
        /// Method to add text to the text box that takes in a delegate
        /// </summary>
        /// <param name="myDel">The delegate provided</param>
        public void addText(Func<int, double, char, string, string> myDel)
        {
            int idata = 1;
            double ddata = 5.1;
            char cdata = 'A';
            string sdata = "Method";
            richTextBox1.Text += myDel(idata, ddata++, cdata++, sdata + idata++);
        }

        /// <summary>
        /// Method to add text to the text box off of a string
        /// </summary>
        /// <param name="inString">The string that will be added to the text box</param>

        public void addText(string inString)
        {
            richTextBox1.Text += inString + "\n";
        }
    }
}

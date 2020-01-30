/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_03
/// Date: 1/24/2020 11:54:15 PM
/// <summary>
/// This is a form that allows you to select which data type you want the max and min values for.
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
    public partial class Form3 : Form
    {
        /// <summary>
        /// Initializes the form
        /// </summary>
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Accidental addition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Accidental addition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the button is clicked, it checks what item is selected and uses it to print what the max and min values are
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            if (selectedItem == null)
            {
                label2.Text = $"NO VALUE SELECTED";
                label4.Text = $"NO VALUE SELECTED";
            } else if (selectedItem.ToString() == "sbyte")
            {
                label2.Text = $"{sbyte.MaxValue}";
                label4.Text = $"{sbyte.MinValue}";
            } else if (selectedItem.ToString() == "byte")
            {
                label2.Text = $"{byte.MaxValue}";
                label4.Text = $"{byte.MinValue}";
            } else if (selectedItem.ToString() == "short")
            {
                label2.Text = $"{short.MaxValue}";
                label4.Text = $"{short.MinValue}";
            } else if (selectedItem.ToString() == "ushort")
            {
                label2.Text = $"{ushort.MaxValue}";
                label4.Text = $"{ushort.MinValue}";
            } else if (selectedItem.ToString() == "int")
            {
                label2.Text = $"{int.MaxValue}";
                label4.Text = $"{int.MinValue}";
            }
            else if (selectedItem.ToString() == "uint")
            {
                label2.Text = $"{uint.MaxValue}";
                label4.Text = $"{uint.MinValue}";
            } else if (selectedItem.ToString() == "long")
            {
                label2.Text = $"{long.MaxValue}";
                label4.Text = $"{long.MinValue}";
            } else if (selectedItem.ToString() == "ulong")
            {
                label2.Text = $"{ulong.MaxValue}";
                label4.Text = $"{ulong.MinValue}";
            } else if (selectedItem.ToString() == "float")
            {
                label2.Text = $"{float.MaxValue}";
                label4.Text = $"{float.MinValue}";
            } else if (selectedItem.ToString() == "double")
            {
                label2.Text = $"{double.MaxValue}";
                label4.Text = $"{double.MinValue}";
            } else if (selectedItem.ToString() == "decimal")
            {
                label2.Text = $"{decimal.MaxValue}";
                label4.Text = $"{decimal.MinValue}";
            } else if (selectedItem.ToString() == "char")
            {
                label2.Text = $"{Convert.ToInt32(char.MaxValue)}";
                label4.Text = $"{Convert.ToInt32(char.MinValue)}";
            } else if (selectedItem.ToString() == "bool")
            {
                label2.Text = $"True";
                label4.Text = $"False";
            } else 
            {
                label2.Text = $"NO VALUE SELECTED";
                label4.Text = $"NO VALUE SELECTED";
            }
        }
    }
}

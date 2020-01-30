/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_03
/// Date: 1/24/2020 11:40:20 PM
/// <summary>
/// This is a form that shows the max and min values of all data types in a RichTextBox.
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
    public partial class Form2 : Form
    {
        /// <summary>
        /// This initializes the form, inserting all the text needed and making sure it will auto-scale
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Text = "";
            richTextBox1.Text += $"sbyte Max: {sbyte.MaxValue} MinValue: {sbyte.MinValue}\n";
            richTextBox1.Text += $"byte Max: {byte.MaxValue} MinValue: {byte.MinValue}\n";
            richTextBox1.Text += $"short Max: {short.MaxValue}  MinValue: {short.MinValue}\n";
            richTextBox1.Text += $"ushort Max: {ushort.MaxValue}  MinValue: {ushort.MinValue}\n";
            richTextBox1.Text += $"int Max: {int.MaxValue}  MinValue: {int.MinValue}\n";
            richTextBox1.Text += $"uint Max: {uint.MaxValue}  MinValue: {uint.MinValue}\n";
            richTextBox1.Text += $"long Max: {long.MaxValue}  MinValue: {long.MinValue}\n";
            richTextBox1.Text += $"ulong Max: {ulong.MaxValue} MinValue: {ulong.MinValue}\n";
            richTextBox1.Text += $"float Max: {float.MaxValue}  MinValue: {float.MinValue}\n";
            richTextBox1.Text += $"double Max: {double.MaxValue}  MinValue: {double.MinValue}\n";
            richTextBox1.Text += $"decimal Max: {decimal.MaxValue}  MinValue: {decimal.MinValue}\n";
            richTextBox1.Text += $"char Max: {Convert.ToInt32(char.MaxValue)}  MinValue: {Convert.ToInt32(char.MinValue)}\n";
            richTextBox1.Text += $"bool Max: True MinValue: False";
        }

    }
}

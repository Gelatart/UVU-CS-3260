/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_04
/// Date: 2/2/2020 1:05:15 AM
/// <summary>
/// Form that allows you to set the complex number values and operation and get a complex number as output
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

namespace Lab4
{

	public partial class ComplexAlgorithm : Form
	{
		/// <summary>
		/// Initializes the form
		/// </summary>
		public ComplexAlgorithm()
		{
			InitializeComponent();
		}
		 /// <summary>
		 /// Method called when complex numbers need to be added
		 /// </summary>
		 /// <param name="c1">First complex number</param>
		 /// <param name="c2">Second complex number</param>
		 /// <returns></returns>
		public ComplexData addition(ComplexData c1, ComplexData c2)
		{
			ComplexData c3 = new ComplexData(0.0, 0.0);
			c3.RealNum = c1.RealNum + c2.RealNum;
			c3.ImagNum = c1.ImagNum + c2.ImagNum;
			return c3;
		}
		/// <summary>
		/// Method called when complex numbers need to be subtracted
		/// </summary>
		/// <param name="c1">First complex number</param>
		/// <param name="c2">Second complex number</param>
		/// <returns></returns>
		public ComplexData subtraction(ComplexData c1, ComplexData c2)
		{
			ComplexData c3 = new ComplexData(0.0, 0.0);
			c3.RealNum = c1.RealNum - c2.RealNum;
			c3.ImagNum = c1.ImagNum - c2.ImagNum;
			return c3;
		}
		/// <summary>
		/// Method called when complex numbers need to be multiplied
		/// </summary>
		/// <param name="c1">First complex number</param>
		/// <param name="c2">Second complex number</param>
		/// <returns></returns>
		public ComplexData multiplication(ComplexData c1, ComplexData c2)
		{
			ComplexData c3 = new ComplexData(0.0, 0.0);
			c3.RealNum = c1.RealNum * c2.RealNum - c1.ImagNum * c2.ImagNum;
			c3.ImagNum = c1.RealNum * c2.ImagNum + c1.ImagNum * c2.RealNum;
			return c3;
		}
		/// <summary>
		/// Method called when complex numbers need to be divided
		/// </summary>
		/// <param name="c1">First complex number</param>
		/// <param name="c2">Second complex number</param>
		/// <returns></returns>
		public ComplexData division(ComplexData c1, ComplexData c2)
		{
			ComplexData c3 = new ComplexData(0.0, 0.0);
			double c1r = c1.RealNum;
			double c1i = c1.ImagNum;
			double c2r = c2.RealNum;
			double c2i = c2.ImagNum;
			c3.RealNum = ((c1r * c2r + c1i * c2i) / (c2r * c2r + c2i * c2i));
			c3.ImagNum = ((c1i * c2r - c1r * c2i) / (c2r * c2r + c2i * c2i));
			return c3;
		}
		/// <summary>
		/// Checks if the data is valid for submission for complex number operations
		/// </summary>
		/// <param name="input">The input string to be parsed for a double</param>
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
				textBoxReal.Text = $"INVALID INPUT";
				textBoxImag.Text = $"INVALID INPUT";
				errorProvider1.SetError(labelError, "Not proper double value!");
				return false;
			}
		}

		/// <summary>
		/// Uses the data provided to see if the form is ready for a complex number operation, and then carries out the specific operation
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			bool v1;
			bool v2;
			bool v3;
			bool v4;
			v1 = validateSubmit(textBox1.Text);
			v2 = validateSubmit(textBox2.Text);
			v3 = validateSubmit(textBox3.Text);
			v4 = validateSubmit(textBox4.Text);
			if(v1 && v2 && v3 && v4)
			{
				Object selectedItem = comboBox1.SelectedItem;
				double c1r = Double.Parse(textBox1.Text);
				double c1i = Double.Parse(textBox2.Text);
				double c2r = Double.Parse(textBox3.Text);
				double c2i = Double.Parse(textBox4.Text);
				ComplexData c1 = new ComplexData(c1r, c1i);
				ComplexData c2 = new ComplexData(c2r, c2i);
				if (selectedItem == null)
				{
					textBoxReal.Text = $"INVALID SELECTION";
					textBoxImag.Text = $"INVALID SELECTION";
				}
				else if (selectedItem.ToString() == "Addition")
				{
					ComplexData temp = addition(c1, c2);
					ComplexData c3 = new ComplexData(temp.RealNum,temp.ImagNum);
					textBoxReal.Text = $"{c3.RealNum.ToString("0.00")}";
					textBoxImag.Text = $"{c3.ImagNum.ToString("0.00")}";
				}
				else if (selectedItem.ToString() == "Subtraction")
				{
					ComplexData temp = subtraction(c1, c2);
					ComplexData c3 = new ComplexData(temp.RealNum, temp.ImagNum);
					textBoxReal.Text = $"{c3.RealNum.ToString("0.00")}";
					textBoxImag.Text = $"{c3.ImagNum.ToString("0.00")}";
				}
				else if (selectedItem.ToString() == "Multiplication")
				{
					ComplexData temp = multiplication(c1, c2);
					ComplexData c3 = new ComplexData(temp.RealNum, temp.ImagNum);
					textBoxReal.Text = $"{c3.RealNum.ToString("0.00")}";
					textBoxImag.Text = $"{c3.ImagNum.ToString("0.00")}";
				}
				else if (selectedItem.ToString() == "Division")
				{
					ComplexData temp = division(c1, c2);
					ComplexData c3 = new ComplexData(temp.RealNum, temp.ImagNum);
					textBoxReal.Text = $"{c3.RealNum.ToString("0.00")}";
					textBoxImag.Text = $"{c3.ImagNum.ToString("0.00")}";
				}
			}
		}

		/// <summary>
		/// Accidental addition
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
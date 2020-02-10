/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_04
/// Date: 2/2/2020 12:59:20 AM
/// <summary>
/// This is a class that contains a complex number, as a combination of two doubles
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

namespace Lab4
{
	public class ComplexData
	{
		/// <summary>
		/// The values for the real number and the imaginary number
		/// </summary>
		private double realNum;
		private double imagNum;
		
		/// <summary>
		/// Getters and setters for the real number
		/// </summary>
		public double RealNum
		{
			get { return realNum; }
			set { realNum = value; }
		}
		/// <summary>
		/// Getters and setters for the imaginary number
		/// </summary>
		public double ImagNum
		{
			get { return imagNum; }
			set { imagNum = value; }
		}
		/// <summary>
		/// Constructor for ComplexData class
		/// </summary>
		/// <param name="rNum">The real number provided for construction</param>
		/// <param name="iNum">The imaginary number provided for construction</param>
		public ComplexData(double rNum, double iNum)
		{
			realNum = rNum;
			imagNum = iNum;
		}
	}
}
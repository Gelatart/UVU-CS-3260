/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_06
/// Date: 3/1/2020 11:37:20 PM
/// <summary>
/// Class that deals with creating all the types of delegates and running tests on them
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

namespace Lab6
{
    public class TestDelegate

    {
        /// <summary>
        /// Declaration of all the delegate types, the list they will go into, and the text that will go into the wrapper
        /// </summary>
        public delegate string delTemplate(int iparam, double dparam, char cparam, string sparam);
        private static delTemplate customDel1 = new delTemplate(customMethod1);
        private static delTemplate customDel2 = customMethod2;
        private delTemplate chainedDel = customDel1 + customDel2;
        private delTemplate anonDel = delegate (int a, double b, char c, string d) { return $"Anonymous Delegate(): int ({a:D}), double ({b:F2}), char ({c}), string ({d})"; };
        private Action<int, double, char, string> actDel = (i, d, c, s) => wrapText += $"Action<T>: int ({i:D}), double ({d:F2}), char ({c}), string ({s})";
        private Func<int, double, char, string, string> funcDel = (i, d, c, s) => $"Func<T>: int ({i:D}), double ({d:F2}), char ({c}), string ({s})";
        private string expression(int i, double d, char c, string s) => $"Expression: int ({i:D}), double ({d:F2}), char ({c}), string ({s})";
        private static List<Func<int, double, char, string, string>> _DList;
        static private string wrapText;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        public TestDelegate()

        {
            generateList();

        }

        /// <summary>
        /// Creates the list as well as a wrapper method for all the delegates that need to go into it
        /// </summary>
        public void generateList()
        {

            Func<int, double, char, string, string> wrappedDel = delWrapper;
            _DList = new List<Func<int, double, char, string, string>>()
                            {

                                funcDel,
                                expression,
                                (i,d,c,s)=>$"Lambda Expression: int ({i:D}), double ({d:f2}), char ({c}), string ({s})",
                                wrappedDel
                            };
        }

        /// <summary>
        /// A method to test out a custom delegate method, to be chained later
        /// </summary>
        /// <param name="i">int</param>
        /// <param name="d">double</param>
        /// <param name="c">char</param>
        /// <param name="s">string</param>
        /// <returns>A string that displays the results</returns>
        static public string customMethod1(int i, double d, char c, string s)
        {
            return $"Custom Method 1: int ({i:D}), double ({d:F2}), char ({c}), string ({s})";
        }
        /// <summary>
        /// Another method to test out a custom delegate method, to be chained later
        /// </summary>
        /// <param name="i">int</param>
        /// <param name="d">double</param>
        /// <param name="c">char</param>
        /// <param name="s">string</param>
        /// <returns>A string that displays the results</returns>
        static public string customMethod2(int i, double d, char c, string s)
        {
            return $"Custom Method 2: int ({i:D}), double ({d:F2}), char ({c}), string ({s})";
        }
        /// <summary>
        /// Runs the tests to be sent to Form1 to display results
        /// </summary>
        /// <param name="form1">The Form1 that will be sending the results to</param>
        public void RunTests(Form1 form1)

        {

            int idata = 1;

            double ddata = 5.1;

            char cdata = 'A';

            string sdata = "Method";
 


            try
            {
                foreach (Func<int, double, char, string, string> myDel in _DList)
                {         
                    form1.addText(myDel(idata, ddata++, cdata++, sdata + idata++));
                }
            }
            catch (NullReferenceException)
            {
                form1.addText("THIS IS NULL");
            }       

        }

        /// <summary>
        /// Wrapper method to put the delegates that need to go in here
        /// </summary>
        /// <param name="i">int</param>
        /// <param name="d">double</param>
        /// <param name="c">char</param>
        /// <param name="s">string</param>
        /// <returns>Returns the text that will display all the results for the wrapper delegates</returns>
        public string delWrapper(int i, double d, char c, string s)
        {
            wrapText += $"{customDel1(i, d, c, s)}\n";
            wrapText += $"{customDel2(i, d, c, s)}\n";
            wrapText += "Chained Del: ";
            wrapText += $"{chainedDel(i, d, c, s)}\n";
            wrapText += $"{anonDel(i, d, c, s)}\n";
            actDel(i, d, c, s);
            return wrapText;
        }

    }//end class TestDelegate
}

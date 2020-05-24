/*
Learning Team in-class assignment
10 points

Download linqAssignment from lesson 10
Using linq, query customer data source using linq method style
Create report (display) of all customers with the following criteria:
From the state of Oregon and purchases greater than $1000

Create 2nd report (display) using linq query style using the following criteria:
From the state of Utah and purchases less than $1000

Both Reports should display the following fields:
First name
Last name
Price
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {       
        #region Create data sources

        static List<Customer> customers = new List<Customer>
        {
            new Customer {First = "Cailin", Last = "Alford", State = "UT", Price = 930.00, Purchases = new string[] {"Panel 625", "Panel 200"}},
            new Customer {First = "Theodore", Last = "Brock", State = "AR", Price = 2100.00, Purchases = new string[] {"12V Li"}},
            new Customer {First = "Jerry", Last = "Gill", State = "UT", Price = 585.80, Purchases = new string[] {"Bulb 23W", "Panel 625"}},
            new Customer {First = "Owens", Last = "Howell", State = "UT", Price = 512.00, Purchases = new string[] {"Panel 200", "Panel 180"}},
            new Customer {First = "Adena", Last = "Jenkins", State = "OR", Price = 2267.80, Purchases = new string[] {"Bulb 23W", "12V Li", "Panel 180"}},
            new Customer {First = "Medge", Last = "Ratliff", State = "UR", Price = 1034.00, Purchases = new string[] {"Panel 625"}},
            new Customer {First = "Sydney", Last = "Bartlett", State = "OR", Price = 2105.00, Purchases = new string[] {"12V Li", "AA NiMH"}},
            new Customer {First = "Malik", Last = "Faulkner", State = "MI", Price = 167.80, Purchases = new string[] {"Bulb 23W", "Panel 180"}},
            new Customer {First = "Serena", Last = "Malone", State = "UT", Price = 512.00, Purchases = new string[] {"Panel 180", "Panel 200"}},
            new Customer {First = "Hadley", Last = "Sosa", State = "OR", Price = 1590.20, Purchases = new string[] {"Panel 625", "Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Nash", Last = "Vasquez", State = "OR", Price = 10.20, Purchases = new string[] {"Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Joshua", Last = "Delaney", State = "UT", Price = 3350.00, Purchases = new string[] {"Panel 200"}}
        };

        
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("FIRST REPORT: \n");
            IEnumerable<Customer> firstReport = customers.Where (n => n.State.Contains("OR") && n.Price > 1000);
            foreach (Customer cust in firstReport) Console.WriteLine(cust.First + "\n" + cust.Last + "\n" + cust.Price + "\n");

            Console.WriteLine("SECOND REPORT: \n");
            IEnumerable<Customer> secondReport = customers.Where(n => n.State.Contains("UT") && n.Price < 1000);
            foreach (Customer cust in secondReport) Console.WriteLine(extensionMethod.toDisplay(cust));

            Console.WriteLine("Learning Team In-Class Activity");
            Console.ReadKey();
        }
    }

    public static class extensionMethod
    {
        public static string toDisplay(this Customer data)
        {
            string result = data.First + "\n" + data.Last + "\n" + data.Price + "\n";
            return result;
        }

    }
}

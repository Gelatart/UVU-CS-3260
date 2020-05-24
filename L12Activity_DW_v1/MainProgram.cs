using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {
        

        #region Create data sources

        static List<Customer> customers = new List<Customer>
        {          
            new Customer {ID = "LD2961", First = "Cailin", Last = "Alford", State = "UT", Price = 930.00, Purchases = new string[] {"Panel 625", "Panel 200"}},
            new Customer {ID = "LD8403", First = "Theodore", Last = "Brock", State = "AR", Price = 2100.00, Purchases = new string[] {"12V Li"}},
            new Customer {ID = "LD7261", First = "Jerry", Last = "Gill", State = "UT", Price = 585.80, Purchases = new string[] {"Bulb 23W", "Panel 625"}},
            new Customer {ID = "LD9918", First = "Owens", Last = "Howell", State = "UT", Price = 512.00, Purchases = new string[] {"Panel 200", "Panel 180"}},
            new Customer {ID = "LD9332", First = "Adena", Last = "Jenkins", State = "OR", Price = 2267.80, Purchases = new string[] {"Bulb 23W", "12V Li", "Panel 180"}},
            new Customer {ID = "LD8300", First = "Medge", Last = "Ratliff", State = "GA", Price = 1034.00, Purchases = new string[] {"Panel 625"}},
            new Customer {ID = "LD8776", First = "Sydney", Last = "Bartlett", State = "OR", Price = 2105.00, Purchases = new string[] {"12V Li", "AA NiMH"}},
            new Customer {ID = "LD1572", First = "Malik", Last = "Faulkner", State = "MI", Price = 167.80, Purchases = new string[] {"Bulb 23W", "Panel 180"}},
            new Customer {ID = "LD1042", First = "Serena", Last = "Malone", State = "UT", Price = 512.00, Purchases = new string[] {"Panel 180", "Panel 200"}},
            new Customer {ID = "LD9674", First = "Hadley", Last = "Sosa", State = "OR", Price = 590.20, Purchases = new string[] {"Panel 625", "Bulb 23W", "Bulb 9W"}},
            new Customer {ID = "LD7414", First = "Nash", Last = "Vasquez", State = "OR", Price = 10.20, Purchases = new string[] {"Bulb 23W", "Bulb 9W"}},
            new Customer {ID = "LD5537", First = "Joshua", Last = "Delaney", State = "UT", Price = 350.00, Purchases = new string[] {"Panel 200"}}
                        
        };

        
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Learning Team In-Class Activity");
            XDocument doc = new XDocument();
            IEnumerable<Customer> report = customers.Where(n => n.State.Contains("UT") && n.Price < 1000);
            XElement root = new XElement("Customers");
            XElement intro = new XElement("Intro");
            intro.Value = "List of customers that match criteria";
            root.Add(intro);
            foreach(Customer cust in report)
            {
                XElement record = new XElement("Customer");
                var id = new XAttribute("ID", cust.ID);
                record.Add(id);
                XElement first = new XElement("FirstName");
                first.Value = cust.First;
                XElement last = new XElement("LastName");
                last.Value = cust.Last;
                XElement state = new XElement("State");
                state.Value = cust.State;
                record.Add(first);
                record.Add(last);
                record.Add(state);
                root.Add(record);
            }
            doc.Add(root);
            doc.Save("output.xml");
            Console.ReadKey();
        }        
    }
}

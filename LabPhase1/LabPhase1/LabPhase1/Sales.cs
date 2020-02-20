using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPhase1
{
    public sealed class Sales : Salary
    {
        public double commission { get; set; }
        public double grossSales { get; set; }
        //method for salary? +1 overl...?
        public Sales()
        {
            //why no arrow underneath?
        }
    }
}

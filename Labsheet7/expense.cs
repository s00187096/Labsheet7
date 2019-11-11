using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet7
{
    public class expense
    {
        //properties
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Category { get; set; }

        //constructors

        //methods
        public override string ToString()
        {
            return $"{Category}{Amount:C} on {ExpenseDate.ToShortDateString()}";
        }
    }
}

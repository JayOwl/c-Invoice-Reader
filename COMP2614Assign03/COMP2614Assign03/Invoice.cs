using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{

    //output model for the collection coming in from the Invoice
    class Invoice
    {
        public int InvoiceNumber { get; set; }


        public DateTime DateTime { get; set; }

        public DateTime DiscountDate { get; set; }

        // public Decimal;

        public override string ToString()
        {
            return $"{InvoiceNumber} {DateTime}";
        }



    }
}

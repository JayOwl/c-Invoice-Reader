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


        public DateTime InvoiceDateTime { get; set; }

        public DateTime InvoiceDiscountDate { get; set; }

        public int InvoiceDiscount { get; set; }

        public int InvoiceQuantity { get; set; }

        public override string ToString()
        {
            return $"{InvoiceNumber} {InvoiceDateTime}  {InvoiceDiscount} {InvoiceQuantity}";
        }



    }
}

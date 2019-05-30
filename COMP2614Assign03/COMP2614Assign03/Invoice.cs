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
        public int InvoiceQuantity2 { get; set; }

      public int InvoiceQuantity3 { get; set; }

        public string InvoiceSku { get; set; }
        public string InvoiceSku2 { get; set; }
        public string InvoiceSku3 { get; set; }

        public string InvoiceDescription { get; set; }
        public string InvoiceDescription2 { get; set; }
        public string InvoiceDescription3 { get; set; }

        public decimal InvoicePrice { get; set; }
        public decimal InvoicePrice2 { get; set; }
       public decimal InvoicePrice3 { get; set; }

        public string InvoicePST { get; set; }
        public string InvoicePST2 { get; set; }
        public string InvoicePST3 { get; set; }

        public decimal InvoiceTotalPrice { get; set; }
        public decimal InvoiceTotalPrice2 { get; set; }
        public decimal InvoiceTotalPrice3 { get; set; }





        public override string ToString()
        {
            return $"{InvoiceNumber} {InvoiceDateTime}  {InvoiceDiscount} {InvoiceQuantity} {InvoiceSku} {InvoicePrice} " +
                $"{InvoiceQuantity2} {InvoiceSku2} {InvoicePrice2} " +
                $"{InvoiceQuantity3} {InvoiceSku3} {InvoicePrice3}";
        }

    }
}

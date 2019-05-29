using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    class ConsolePrinter
    {
        public static void ShowInvoice(InvoiceCollection invoices)
        {
            Console.WriteLine("Invoice Listing");
            Console.WriteLine(new string('-', 38));
            foreach (Invoice invoice in invoices)
            {       
                Console.WriteLine("{0} {1}","Invoice Number: ", invoice.InvoiceNumber);
                Console.WriteLine("{0} {1}", "Invoice Date: ", invoice.InvoiceDateTime);
                //Console.WriteLine("{0} {1}", "Discount Date: ", invoice.InvoiceDiscountDate);
                Console.WriteLine("{0}% {1}", "Terms: ", invoice.InvoiceDiscount);


                Console.WriteLine("{0}% {1}", "Invoice Quanitty: ", invoice.InvoiceQuantity);

                Console.WriteLine("{0} {1}", "Invoice Sku: ", invoice.InvoiceSku);

                Console.WriteLine("{0} {1}", "Invoice Description: ", invoice.InvoiceDescription);

                Console.WriteLine("{0} {1}", "Invoice Price: ", invoice.InvoicePrice);

                Console.WriteLine("{0} {1}", "Invoice PST: ", invoice.InvoicePST);
            }
            Console.WriteLine();
        }

    }
}

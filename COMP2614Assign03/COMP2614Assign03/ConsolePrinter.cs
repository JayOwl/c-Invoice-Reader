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
                Console.WriteLine("{0} {1}","Invoice Number: ", invoice);
               // Console.WriteLine("{0} {1}", "Invoice Date: ", DateTime);
            }
            Console.WriteLine();
        }

    }
}

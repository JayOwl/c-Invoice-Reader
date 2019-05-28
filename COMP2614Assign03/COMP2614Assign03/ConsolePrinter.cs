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
            foreach (Invoice invoice in invoices)
            {
                Console.WriteLine(invoice);
            }
            Console.WriteLine();
        }

    }
}

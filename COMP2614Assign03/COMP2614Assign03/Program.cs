using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{

    class Program
    {
        static void Main(string[] args)
        {
            InvoiceCollection invoices = DataGenerator.GetInvoices();
            ConsolePrinter.ShowInvoice(invoices);
            
        }         
    }
}

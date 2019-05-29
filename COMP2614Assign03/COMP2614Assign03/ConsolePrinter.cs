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
              
                Console.WriteLine(new string('-', 38));
                Console.WriteLine("{0, -15} {1, 15} {2,15} {3,15} {4,15} {5,15}", "Qty", "SKU", "Description", "Price", "PST", "Ext");
                Console.WriteLine("{0, -15} {1, 15} {2,15} {3,15} {4,15} {5,15}", invoice.InvoiceQuantity, invoice.InvoiceSku, invoice.InvoiceDescription, invoice.InvoicePrice, invoice.InvoicePST, invoice.InvoiceTotalPrice);
                Console.WriteLine("{0, -15} {1, 15} {2,15} {3,15} {4,15} {5,15}", invoice.InvoiceQuantity2, invoice.InvoiceSku2, invoice.InvoiceDescription2, invoice.InvoicePrice2, invoice.InvoicePST2, invoice.InvoiceTotalPrice2);
                Console.WriteLine(new string('-', 38));

                //Console.WriteLine("{0} {1}", "Invoice Sku: ", invoice.InvoiceSku);

                //Console.WriteLine("{0} {1}", "Invoice Description: ", invoice.InvoiceDescription);

                //Console.WriteLine("{0} {1}", "Invoice Price: ", invoice.InvoicePrice);

                //Console.WriteLine("{0} {1}", "Invoice PST: ", invoice.InvoicePST);
            }
            //Console.WriteLine();
        }

    }
}

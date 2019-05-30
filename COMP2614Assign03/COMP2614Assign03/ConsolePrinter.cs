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
            Console.Title = "COMP2614 - Assignment 03 - Invoice Parser - A00838629";

            Console.WriteLine("Invoice Listing");
            Console.WriteLine(new string('-', 78));
            foreach (Invoice invoice in invoices)
            {       
                Console.WriteLine("{0} {1}","Invoice Number: ", invoice.InvoiceNumber);
                Console.WriteLine("{0} {1}", "Invoice Date: ", invoice.InvoiceDateTime);
                Console.WriteLine("{0} {1}", "Discount Date: ", invoice.InvoiceDiscountDate);
                Console.WriteLine("{0} {1}%", "Terms: ", invoice.InvoiceDiscount);
                decimal subTotal = invoice.InvoiceTotalPrice + invoice.InvoiceTotalPrice2 + invoice.InvoiceTotalPrice3;
                decimal gst = 0.05m;                
                decimal taxGst = gst * subTotal;

                decimal total = subTotal + GetPst(invoice.InvoicePrice) + GetPst(invoice.InvoicePrice) + GetPst(invoice.InvoicePrice) + taxGst;



                Console.WriteLine(new string('-', 78));
                Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", "Qty", "SKU", "Description", "Price", "PST", "Ext");
                Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", invoice.InvoiceQuantity, invoice.InvoiceSku, invoice.InvoiceDescription, invoice.InvoicePrice, invoice.InvoicePST, invoice.InvoiceTotalPrice);
                Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", invoice.InvoiceQuantity2, invoice.InvoiceSku2, invoice.InvoiceDescription2, invoice.InvoicePrice2, invoice.InvoicePST2, invoice.InvoiceTotalPrice2);
                if (invoice.InvoiceQuantity3 != 0)
                {
                    Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", invoice.InvoiceQuantity3, invoice.InvoiceSku3, invoice.InvoiceDescription3, invoice.InvoicePrice3, invoice.InvoicePST3, invoice.InvoiceTotalPrice3);
                }
                Console.WriteLine(new string('-', 78));
                Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", "", "SubTotal: ","", "", "", subTotal);
                Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", "", "GST", "", "", "", taxGst);
                if (invoice.InvoicePST == "Y")
                {
                    Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", "", "PST", "", "", "", GetPst(invoice.InvoicePrice));
                }          
                if (invoice.InvoicePST2 == "Y")
                {
                    Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", "", "PST", "", "", "", GetPst(invoice.InvoicePrice2));
                }
                if (invoice.InvoicePST3 == "Y")
                {
                    Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", "", "PST", "", "", "", GetPst(invoice.InvoicePrice3));
                }
                Console.WriteLine(new string('-', 78));
                Console.WriteLine("{0, -15} {1, -10} {2,-20} {3,-7} {4,10} {5,10}", "", "Total:", "", "", "", total);
              
            }

            decimal GetPst(decimal productCost)
            {
                decimal pst = 0.07m;
                return productCost * pst;
            }

          

        }
       
    }
}

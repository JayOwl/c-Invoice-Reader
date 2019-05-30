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
            Console.WriteLine("\r");

            foreach (Invoice invoice in invoices)
            {
                TimeSpan discountDates = invoice.InvoiceDiscountDate.Subtract(invoice.InvoiceDateTime);

                Console.WriteLine("{0,-20} {1,5}", "Invoice Number: ", invoice.InvoiceNumber);
                Console.WriteLine("{0,-20} {1,5}", "Invoice Date: ", invoice.InvoiceDateTime.ToString("MMMM dd, yyyy"));
                Console.WriteLine("{0,-20} {1,5}", "Discount Date: ", invoice.InvoiceDiscountDate.ToString("MMMM dd, yyyy"));
                Console.WriteLine("{0,-19} {1,5:0.00}% {2} {3}", "Terms: ", invoice.InvoiceDiscount, discountDates.ToString("dd"), "days ADI");
                decimal subTotal = invoice.InvoiceTotalPrice + invoice.InvoiceTotalPrice2 + invoice.InvoiceTotalPrice3;
                decimal gst = 0.05m;                
                decimal taxGst = gst * subTotal;
                decimal total = subTotal + GetPst(invoice.InvoicePrice) + GetPst(invoice.InvoicePrice) + GetPst(invoice.InvoicePrice) + taxGst;
                decimal totalDisount = (invoice.InvoiceDiscount / 100) * total;

                Console.WriteLine(new string('-', 81));
                Console.WriteLine("{0} {1,8} {2,20} {3,20} {4,10} {5,15}", "Qty", "SKU", "Description", "Price", "PST", "Ext");
                if (invoice.InvoiceQuantity != 0)
                {
                    Console.WriteLine("{0,3} {1,10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", invoice.InvoiceQuantity, invoice.InvoiceSku, invoice.InvoiceDescription, invoice.InvoicePrice, invoice.InvoicePST, invoice.InvoiceTotalPrice);
                }
                if (invoice.InvoiceQuantity2 != 0)
                {
                    Console.WriteLine("{0,3} {1,10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", invoice.InvoiceQuantity2, invoice.InvoiceSku2, invoice.InvoiceDescription2, invoice.InvoicePrice2, invoice.InvoicePST2, invoice.InvoiceTotalPrice2);
                }
                if (invoice.InvoiceQuantity3 != 0)
                {
                    Console.WriteLine("{0,3} {1,10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", invoice.InvoiceQuantity3, invoice.InvoiceSku3, invoice.InvoiceDescription3, invoice.InvoicePrice3, invoice.InvoicePST3, invoice.InvoiceTotalPrice3);
                }
                Console.WriteLine(new string('-', 80));
                Console.WriteLine("{0,3} {1,-10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", "", "SubTotal: ","", "", "", subTotal);
                Console.WriteLine("{0,3} {1,-10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", "", "GST: ", "", "", "", taxGst);
                if (invoice.InvoicePST == "Y")
                {
                    Console.WriteLine("{0,3} {1,-10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", "", "PST", "", "", "", GetPst(invoice.InvoicePrice));
                }          
                if (invoice.InvoicePST2 == "Y")
                {
                    Console.WriteLine("{0,3} {1,-10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", "", "PST", "", "", "", GetPst(invoice.InvoicePrice2));
                }
                if (invoice.InvoicePST3 == "Y")
                {
                    Console.WriteLine("{0,3} {1,-10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", "", "PST", "", "", "", GetPst(invoice.InvoicePrice3));
                }
                Console.WriteLine(new string('-', 80));
                Console.WriteLine("{0,3} {1,-10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", "", "Total:", "", "", "", total);
                Console.WriteLine("{0,3} {1,-10} {2,20} {3,18:0,0.00} {4,9} {5,16:0,0.00}", "", "Discount:", "", "", "", totalDisount);
                Console.WriteLine("\r");
                Console.WriteLine("\r");
            }

            decimal GetPst(decimal productCost)
            {
                decimal pst = 0.07m;
                return productCost * pst;
            }          

        }       
    }
}

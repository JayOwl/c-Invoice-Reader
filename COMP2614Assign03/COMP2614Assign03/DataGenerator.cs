using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    class DataGenerator
    {

        public static InvoiceCollection GetInvoices()
        {
            int invoiceNumber;
            int invoiceDiscount;
            int invoiceChangeTime;
            int invoiceQuantity;
            int invoiceQuantity2;
            decimal invoicePrice;

            string invoiceSku;
            string invoiceDescription;
            string invoicePst;
            DateTime invoiceDateTime;
            DateTime invoiceDiscountDate;

            List<string> lines = new List<string>();
            List<string> splitLinesByColonList = new List<string>();
            List<string> invoiceSkuList = new List<string>();
            List<string> invoiceDescriptionList = new List<string>();
            List<string> invoicePSTList = new List<string>();
            List<int> invoiceNumberList = new List<int>();
            List<int> invoiceQuantityList = new List<int>();
            List<decimal> invoicePriceList = new List<decimal>();
            List<DateTime> invoiceDateTimeList = new List<DateTime>();
            //List<DateTime> invoiceDiscountDateList = new List<DateTime>();
            List<int> invoiceDiscountList = new List<int>();
            using (StreamReader reader = new StreamReader("...\\...\\invoiceData.txt"))
            {
                string line;      

                while ((line = reader.ReadLine()) != null)
                {       

                    lines.Add(line);
                    string[] splitLineByColon = line.Split(':');
                    string[] splitLineByPipe = line.Split('|');
                    string[] splitByPipeandColon = splitLineByPipe.Skip(1).ToArray();

                    string[] firstItemDetail = splitByPipeandColon[0].Split(':');
                    string[] secondItemDetail = splitByPipeandColon[1].Split(':');
                    //string[] thirdDetail = splitByPipeandColon[2].Split(':');           

                    //string[] fourthDetail = splitByPipeandColon[3].Split(':');


                    invoiceNumber = Convert.ToInt32(splitLineByColon[0]);
                    invoiceNumberList.Add(invoiceNumber);

                    invoiceDateTime = DateTime.Parse(splitLineByColon[1]);
                    invoiceDateTimeList.Add(invoiceDateTime);


                    //invoiceDiscountDate = DateTime.Parse(splitLineByColon[2]);
                    //invoiceDiscountDateList.Add(invoiceDiscountDate);

                    invoiceDiscount = Convert.ToInt32(splitLineByColon[2]);
                    invoiceDiscountList.Add(invoiceDiscount);




                    invoiceQuantity = Convert.ToInt32(firstItemDetail[0]);
                    invoiceQuantity2 = Convert.ToInt32(secondItemDetail[0]);
                    invoiceQuantityList.Add(invoiceQuantity);
                    invoiceQuantityList.Add(invoiceQuantity2);

                    invoiceSku = firstItemDetail[1];
                    invoiceSkuList.Add(invoiceSku);

                    invoiceDescription = firstItemDetail[2];
                    invoiceDescriptionList.Add(invoiceDescription);

                    invoicePrice = Convert.ToDecimal(firstItemDetail[3]);
                    invoicePriceList.Add(invoicePrice);

                    invoicePst = firstItemDetail[4];
                    invoicePSTList.Add(invoicePst);



                }

                //int intInvoiceNumbers = 0;
                //foreach (string value in lines)
                //{
                //    string invoiceNumbers;    


                //}
            }


                //object getSectionByColon = null;
               

        InvoiceCollection invoices = new InvoiceCollection();

            invoices.Add(new Invoice
            {
                InvoiceNumber = invoiceNumberList[0],
                InvoiceDateTime = invoiceDateTimeList[0],
                InvoiceDiscount = invoiceDiscountList[0],
                InvoiceQuantity = invoiceQuantityList[0],
                InvoiceSku = invoiceSkuList[0],
                InvoiceDescription = invoiceDescriptionList[0],
                InvoicePrice = invoicePriceList[0],
                InvoicePST = invoicePSTList[0]
            }); ;

        invoices.Add(new Invoice {
                 InvoiceNumber = invoiceNumberList[1],
                InvoiceDateTime = invoiceDateTimeList[1],
                InvoiceDiscount = invoiceDiscountList[1],
                InvoiceQuantity = invoiceQuantityList[1],
                InvoiceSku = invoiceSkuList[1],
                InvoiceDescription = invoiceDescriptionList[1],
                InvoicePrice = invoicePriceList[1],
                InvoicePST = invoicePSTList[1]
        });

        invoices.Add(new Invoice {
                InvoiceNumber = invoiceNumberList[2],
                InvoiceDateTime = invoiceDateTimeList[2],
                InvoiceDiscount = invoiceDiscountList[2],
                InvoiceQuantity = invoiceQuantityList[2],
                InvoiceSku = invoiceSkuList[2],
                InvoiceDescription = invoiceDescriptionList[1],
                InvoicePrice = invoicePriceList[2],
                InvoicePST = invoicePSTList[2]
        });

            //invoicesString = invoices;
        return invoices;

            

        }
    }
}

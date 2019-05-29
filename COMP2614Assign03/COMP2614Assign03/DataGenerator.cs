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
            DateTime invoiceDateTime;
            DateTime invoiceDiscountDate;
            List<string> lines = new List<string>();
            List<string> splitLinesByColonList = new List<string>();
            List<int> invoiceNumberList = new List<int>();
            List<int> invoiceQuantityList = new List<int>();
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

                    for (int i = 0; i < splitByPipeandColon.Length; i++)
                    {            
                        string[] splitStringArray = splitByPipeandColon[i].Split(':');
                        invoiceQuantity = Convert.ToInt32(splitStringArray[0]);
                        invoiceQuantityList.Add(invoiceQuantity);
                    }
                        invoiceNumber = Convert.ToInt32(splitLineByColon[0]);
                        invoiceNumberList.Add(invoiceNumber);

                        invoiceDateTime = DateTime.Parse(splitLineByColon[1]);
                        invoiceDateTimeList.Add(invoiceDateTime);


                        //invoiceDiscountDate = DateTime.Parse(splitLineByColon[2]);
                        //invoiceDiscountDateList.Add(invoiceDiscountDate);

                        invoiceDiscount = Convert.ToInt32(splitLineByColon[2]);
                        invoiceDiscountList.Add(invoiceDiscount);

             


                }

                //int intInvoiceNumbers = 0;
                //foreach (string value in lines)
                //{
                //    string invoiceNumbers;    


                //}
            }


                //object getSectionByColon = null;
               

        InvoiceCollection invoices = new InvoiceCollection();
        invoices.Add(new Invoice { InvoiceNumber = invoiceNumberList[0], InvoiceDateTime = invoiceDateTimeList[0],
                                    InvoiceDiscount = invoiceDiscountList[0], InvoiceQuantity = invoiceQuantityList[0] });
        invoices.Add(new Invoice { InvoiceNumber = invoiceNumberList[1], InvoiceDateTime = invoiceDateTimeList[1],
                                    InvoiceDiscount = invoiceDiscountList[1], InvoiceQuantity = invoiceQuantityList[1] });
        invoices.Add(new Invoice { InvoiceNumber = invoiceNumberList[2], InvoiceDateTime = invoiceDateTimeList[2],
                                    InvoiceDiscount = invoiceDiscountList[2], InvoiceQuantity = invoiceQuantityList[2] });

            //invoicesString = invoices;
        return invoices;

            

        }
    }
}

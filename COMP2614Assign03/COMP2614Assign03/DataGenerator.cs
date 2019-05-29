﻿using System;
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
            //int invoiceChangeTime;
            
            
         
            DateTime invoiceDateTime;
            //DateTime invoiceDiscountDate;

            List<string> lines = new List<string>();
            List<string> splitLinesByColonList = new List<string>();
           
         
            List<int> invoiceNumberList = new List<int>();

            List<DateTime> invoiceDateTimeList = new List<DateTime>();
            //List<DateTime> invoiceDiscountDateList = new List<DateTime>();
            List<int> invoiceDiscountList = new List<int>();


            int invoiceQuantity;
            int invoiceQuantity2;
            //int invoiceQuantity3;

            string invoiceSku;
            string invoiceSku2;
            //string invoiceSku3;

            string invoiceDescription;
            string invoiceDescription2;
            //string invoiceDescription3;

            decimal invoicePrice;
            decimal invoicePrice2;
            //decimal invoicePrice3;

            string invoicePst;
            string invoicePst2;
            //string invoicePst3;

            decimal invoiceTotalPrice;
            decimal invoiceTotalPrice2;
            //decimal invoiceTotalPrice3;

            List<int> invoiceQuantityList = new List<int>();
            List<int> invoiceQuantityList2 = new List<int>();
            List<int> invoiceQuantityList3 = new List<int>();

            List<string> invoiceSkuList = new List<string>();
            List<string> invoiceSkuList2 = new List<string>();
            List<string> invoiceSkuList3 = new List<string>();

            List<string> invoiceDescriptionList = new List<string>();
            List<string> invoiceDescriptionList2 = new List<string>();
            List<string> invoiceDescriptionList3 = new List<string>();

            List<decimal> invoicePriceList = new List<decimal>();
            List<decimal> invoicePriceList2 = new List<decimal>();
            List<decimal> invoicePriceList3 = new List<decimal>();

            List<string> invoicePSTList = new List<string>();
            List<string> invoicePSTList2 = new List<string>();
            List<string> invoicePSTList3 = new List<string>();

            List<decimal> invoiceTotalPriceList = new List<decimal>();
            List<decimal> invoiceTotalPriceList2 = new List<decimal>();
            List<decimal> invoiceTotalPriceList3 = new List<decimal>();


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
                   // string[] thirdItemDetail = splitByPipeandColon[2].Split(':');

                    //foreach (int i = 0; i < thirdItemDetail.Length; i++)
                    //{
                        
                    //}

                   
                    //if (thirdItemDetail.Length < 0)
                    //{
                    //    return null;
                    //}
                    //else
                    //{
                       
                    //}



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
                    invoiceQuantityList.Add(invoiceQuantity);

                    invoiceQuantity2 = Convert.ToInt32(secondItemDetail[0]);
                    invoiceQuantityList2.Add(invoiceQuantity2);

                    //invoiceQuantity3 = Convert.ToInt32(thirdItemDetail[0]);
                    //invoiceQuantityList3.Add(invoiceQuantity3);


                    invoiceSku = firstItemDetail[1];
                    invoiceSkuList.Add(invoiceSku);

                    invoiceSku2 = secondItemDetail[1];
                    invoiceSkuList2.Add(invoiceSku2);

                    //invoiceSku3 = thirdItemDetail[1];
                    //invoiceSkuList.Add(invoiceSku3);


                    invoiceDescription = firstItemDetail[2];
                    invoiceDescriptionList.Add(invoiceDescription);

                    invoiceDescription2 = secondItemDetail[2];
                    invoiceDescriptionList2.Add(invoiceDescription2);

                    //invoiceDescription3 = thirdItemDetail[2];
                    //invoiceDescriptionList3.Add(invoiceDescription3);


                    invoicePrice = Convert.ToDecimal(firstItemDetail[3]);
                    invoicePriceList.Add(invoicePrice);

                    invoicePrice2 = Convert.ToDecimal(secondItemDetail[3]);
                    invoicePriceList2.Add(invoicePrice2);

                    //invoicePrice3 = Convert.ToDecimal(thirdItemDetail[3]);
                    //invoicePriceList3.Add(invoicePrice3);


                    invoicePst = firstItemDetail[4];
                    invoicePSTList.Add(invoicePst);

                    invoicePst2 = secondItemDetail[4];
                    invoicePSTList2.Add(invoicePst2);

                    //invoicePst3 = thirdItemDetail[4];
                    //invoicePSTList3.Add(invoicePst3);


                    invoiceTotalPrice = Convert.ToDecimal(invoiceQuantity * invoicePrice);
                    invoiceTotalPriceList.Add(invoiceTotalPrice);

                    invoiceTotalPrice2 = Convert.ToDecimal(invoiceQuantity2 * invoicePrice2);
                    invoiceTotalPriceList2.Add(invoiceTotalPrice2);

                    //invoiceTotalPrice3 = Convert.ToDecimal(invoiceQuantity3 * invoicePrice3);
                    //invoiceTotalPriceList3.Add(invoiceTotalPrice3);

                }     
            }


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
                InvoicePST = invoicePSTList[0],
                InvoiceTotalPrice = invoiceTotalPriceList[0],


                InvoiceQuantity2 = invoiceQuantityList2[0],
                InvoiceSku2 = invoiceSkuList2[0],
                InvoiceDescription2 = invoiceDescriptionList2[0],
                InvoicePrice2 = invoicePriceList2[0],
                InvoicePST2 = invoicePSTList2[0],
                InvoiceTotalPrice2 = invoiceTotalPriceList2[0]
        }); ;

        invoices.Add(new Invoice {
                InvoiceNumber = invoiceNumberList[1],
                InvoiceDateTime = invoiceDateTimeList[1],
                InvoiceDiscount = invoiceDiscountList[1],

                InvoiceQuantity = invoiceQuantityList[1],
                InvoiceSku = invoiceSkuList[1],
                InvoiceDescription = invoiceDescriptionList[1],
                InvoicePrice = invoicePriceList[1],
                InvoicePST = invoicePSTList[1],
                InvoiceTotalPrice = invoiceTotalPriceList[1],

                InvoiceQuantity2 = invoiceQuantityList2[1],
                InvoiceSku2= invoiceSkuList2[1],
                InvoiceDescription2 = invoiceDescriptionList2[1],
                InvoicePrice2 = invoicePriceList2[1],
                InvoicePST2 = invoicePSTList2[1],
                InvoiceTotalPrice2 = invoiceTotalPriceList2[1]
        });

        invoices.Add(new Invoice {
                InvoiceNumber = invoiceNumberList[2],
                InvoiceDateTime = invoiceDateTimeList[2],
                InvoiceDiscount = invoiceDiscountList[2],

                InvoiceQuantity = invoiceQuantityList[2],
                InvoiceSku = invoiceSkuList[2],
                InvoiceDescription = invoiceDescriptionList[1],
                InvoicePrice = invoicePriceList[2],
                InvoicePST = invoicePSTList[2],
                InvoiceTotalPrice = invoiceTotalPriceList[2],

                InvoiceQuantity2 = invoiceQuantityList2[2],
                InvoiceSku2 = invoiceSkuList2[2],
                InvoiceDescription2 = invoiceDescriptionList2[1],
                InvoicePrice2 = invoicePriceList2[2],
                InvoicePST2 = invoicePSTList2[2],
                InvoiceTotalPrice2 = invoiceTotalPriceList2[2]
        });

            //invoicesString = invoices;
        return invoices;

            

        }
    }
}

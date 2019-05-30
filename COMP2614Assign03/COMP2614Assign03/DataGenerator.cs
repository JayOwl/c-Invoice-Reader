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
            int invoiceQuantity3;

            string invoiceSku;
            string invoiceSku2;
            string invoiceSku3;

            string invoiceDescription;
            string invoiceDescription2;
            string invoiceDescription3;

            decimal invoicePrice;
            decimal invoicePrice2;
            decimal invoicePrice3;

            string invoicePst;
            string invoicePst2;
            string invoicePst3;

            decimal invoiceTotalPrice;
            decimal invoiceTotalPrice2;
            decimal invoiceTotalPrice3;

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
                // string[] thirdItemDetail;
                while ((line = reader.ReadLine()) != null)
                {

                    lines.Add(line);
                    string[] splitLineByColon = line.Split(':');
                    string[] splitLineByPipe = line.Split('|');
                    string[] splitByPipeandColon = splitLineByPipe.Skip(1).ToArray();

                    string[] firstItemDetail = splitByPipeandColon[0].Split(':');
                    string[] secondItemDetail = splitByPipeandColon.ElementAtOrDefault(1) != null ? splitByPipeandColon.ElementAtOrDefault(1).Split(':') : new string [] { "" };
                    string[] thirdItemDetail = splitByPipeandColon.ElementAtOrDefault(2) != null ? splitByPipeandColon.ElementAtOrDefault(2).Split(':') : new string[] { "" };





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

                    string value = GetValueOrEmpty(thirdItemDetail, 0);
                    int.TryParse(value, out invoiceQuantity3);
                    invoiceQuantityList3.Add(invoiceQuantity3);


                    invoiceSku = firstItemDetail[1];
                    invoiceSkuList.Add(invoiceSku);

                    //invoiceSku2 = secondItemDetail[1];
                    string sku2 = GetValueOrEmpty(secondItemDetail, 1);
                    invoiceSkuList2.Add(sku2);

                   // invoiceSku3 = thirdItemDetail[1];
                    string sku3 = GetValueOrEmpty(thirdItemDetail, 1);
                    invoiceSkuList3.Add(sku3);


                    invoiceDescription = firstItemDetail[2];
                    string descript = GetValueOrEmpty(firstItemDetail, 2);
                    invoiceDescriptionList.Add(descript);

                    invoiceDescription2 = secondItemDetail[2];
                    invoiceDescriptionList2.Add(invoiceDescription2);

                 
                    string descript3 = GetValueOrEmpty(thirdItemDetail, 2);
                    invoiceDescriptionList3.Add(descript3);


                    invoicePrice = Convert.ToDecimal(firstItemDetail[3]);
                    invoicePriceList.Add(invoicePrice);

                    invoicePrice2 = Convert.ToDecimal(secondItemDetail[3]);
                    invoicePriceList2.Add(invoicePrice2);

                    string price = GetValueOrEmpty(thirdItemDetail, 3);
                    decimal.TryParse(price, out invoicePrice3);
                    invoicePriceList3.Add(invoicePrice3);


                    invoicePst = firstItemDetail[4];
                    invoicePSTList.Add(invoicePst);

                    //string pst2 = GetValueOrEmpty(thirdItemDetail, 4);
                    //invoicePSTList3.Add(pst2);


                    invoicePst2 = firstItemDetail[4];
                    invoicePSTList2.Add(invoicePst2);

                    //string pst2 = GetValueOrEmpty(thirdItemDetail, 4);
                    //invoicePSTList3.Add(pst2);

                    string pst3 = GetValueOrEmpty(thirdItemDetail, 4);
                    invoicePSTList3.Add(pst3);


                    invoiceTotalPrice = Convert.ToDecimal(invoiceQuantity * invoicePrice);
                    invoiceTotalPriceList.Add(invoiceTotalPrice);

                    invoiceTotalPrice2 = Convert.ToDecimal(invoiceQuantity2 * invoicePrice2);
                    invoiceTotalPriceList2.Add(invoiceTotalPrice2);

                    invoiceTotalPrice3 = Convert.ToDecimal(invoiceQuantity3 * invoicePrice3);
                    invoiceTotalPriceList3.Add(invoiceTotalPrice3);

 
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
                InvoiceTotalPrice2 = invoiceTotalPriceList2[0],

                InvoiceQuantity3 = invoiceQuantityList3[0],
                InvoiceSku3 = invoiceSkuList3[0],
                InvoiceDescription3 = invoiceDescriptionList3[0],
                InvoicePrice3 = invoicePriceList3[0],
                InvoicePST3 = invoicePSTList3[0],
                InvoiceTotalPrice3 = invoiceTotalPriceList3[0]
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
                InvoiceTotalPrice2 = invoiceTotalPriceList2[1],

                InvoiceQuantity3 = invoiceQuantityList3[1],
                InvoiceSku3 = invoiceSkuList3[1],
                InvoiceDescription3 = invoiceDescriptionList3[1],
                InvoicePrice3 = invoicePriceList3[1],
                InvoicePST3 = invoicePSTList3[1],
                InvoiceTotalPrice3 = invoiceTotalPriceList3[1]
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
                InvoiceTotalPrice2 = invoiceTotalPriceList2[2],

                InvoiceQuantity3 = invoiceQuantityList3[2],
                InvoiceSku3 = invoiceSkuList3[2],
                InvoiceDescription3 = invoiceDescriptionList3[2],
                InvoicePrice3 = invoicePriceList3[2],
                InvoicePST3 = invoicePSTList3[2],
                InvoiceTotalPrice3 = invoiceTotalPriceList3[2]
        });

            //invoicesString = invoices;
        return invoices;            

        }

        static string GetValueOrEmpty(string[] items, int index)
        {

            string value = items.ElementAtOrDefault(index);
            if (value != null)
                return value;
            else return "";
        }
    }
}

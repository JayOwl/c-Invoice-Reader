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
            decimal invoiceDiscount;
            //int invoiceChangeTime;
            //int intInvoiceDiscoutnDate;


            DateTime invoiceDateTime;
            DateTime invoiceDiscountDate;

            List<string> lines = new List<string>();
            List<string> splitLinesByColonList = new List<string>();


            List<int> invoiceNumberList = new List<int>();

            List<DateTime> invoiceDateTimeList = new List<DateTime>();
            List<DateTime> invoiceDiscountDateList = new List<DateTime>();
            List<decimal> invoiceDiscountList = new List<decimal>();


            int invoiceQuantity;
            int invoiceQuantity2;
            int invoiceQuantity3;

            decimal invoicePrice;
            decimal invoicePrice2;
            decimal invoicePrice3;

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

                    //string[] firstItemDetail = splitByPipeandColon[0].Split(':');
                    string[] firstItemDetail = splitByPipeandColon.ElementAtOrDefault(0) != null ? splitByPipeandColon.ElementAtOrDefault(0).Split(':') : new string[] { "" };
                    string[] secondItemDetail = splitByPipeandColon.ElementAtOrDefault(1) != null ? splitByPipeandColon.ElementAtOrDefault(1).Split(':') : new string [] { "" };
                    string[] thirdItemDetail = splitByPipeandColon.ElementAtOrDefault(2) != null ? splitByPipeandColon.ElementAtOrDefault(2).Split(':') : new string[] { "" };


                    invoiceNumber = Convert.ToInt32(splitLineByColon[0]);
                    invoiceNumberList.Add(invoiceNumber);


                    invoiceDateTime = Convert.ToDateTime(splitLineByColon[1]);
                    invoiceDateTimeList.Add(invoiceDateTime);

                    string invoiceDiscountDateSubstring = splitLineByColon[3].Substring(0, 2);
                    int intInvoiceDiscountDate = Convert.ToInt32(invoiceDiscountDateSubstring);
                    TimeSpan discountTime = new TimeSpan(intInvoiceDiscountDate, 0, 0, 0);
                    DateTime invoicedDiscountDateTime = invoiceDateTime.Add(discountTime);
                    invoiceDiscountDateList.Add(invoicedDiscountDateTime);

                    invoiceDiscount = Convert.ToDecimal(splitLineByColon[2]);
                    invoiceDiscountList.Add(invoiceDiscount);
     

                    string quantity = GetValueOrEmpty(firstItemDetail, 0);
                    int.TryParse(quantity, out invoiceQuantity);
                    invoiceQuantityList.Add(invoiceQuantity);


                    string quantity2 = GetValueOrEmpty(secondItemDetail, 0);
                    int.TryParse(quantity2, out invoiceQuantity2);
                    invoiceQuantityList2.Add(invoiceQuantity2);

                    string quantity3 = GetValueOrEmpty(thirdItemDetail, 0);
                    int.TryParse(quantity3, out invoiceQuantity3);
                    invoiceQuantityList3.Add(invoiceQuantity3);


                    string invoiceSku = GetValueOrEmpty(firstItemDetail, 1);
                    invoiceSkuList.Add(invoiceSku);
               
                    string invoiceSku2 = GetValueOrEmpty(secondItemDetail, 1);
                    invoiceSkuList2.Add(invoiceSku2);

                    string invoiceSku3 = GetValueOrEmpty(thirdItemDetail, 1);
                    invoiceSkuList3.Add(invoiceSku3);

             
                    string invoiceDescription = GetValueOrEmpty(firstItemDetail, 2);
                    invoiceDescriptionList.Add(invoiceDescription);

                    string invoiceDescription2 = GetValueOrEmpty(secondItemDetail, 2);
                    invoiceDescriptionList2.Add(invoiceDescription2);

                    string invoiceDescription3 = GetValueOrEmpty(thirdItemDetail, 2);
                    invoiceDescriptionList3.Add(invoiceDescription3);


                    string price = GetValueOrEmpty(firstItemDetail, 3);
                    decimal.TryParse(price, out invoicePrice);
                    invoicePriceList.Add(invoicePrice);

                    string price2 = GetValueOrEmpty(secondItemDetail, 3);
                    decimal.TryParse(price2, out invoicePrice2);
                    invoicePriceList2.Add(invoicePrice2);

                    string price3 = GetValueOrEmpty(thirdItemDetail, 3);
                    decimal.TryParse(price3, out invoicePrice3);
                    invoicePriceList3.Add(invoicePrice3);
 

                    string invoicePst = GetValueOrEmpty(firstItemDetail, 4);
                    invoicePSTList.Add(invoicePst);

                    string invoicePst2 = GetValueOrEmpty(secondItemDetail, 4);
                    invoicePSTList2.Add(invoicePst2);

                    string invoicePst3 = GetValueOrEmpty(thirdItemDetail, 4);
                    invoicePSTList3.Add(invoicePst3);

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
                InvoiceDiscountDate = invoiceDiscountDateList[0],

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
                InvoiceDiscountDate = invoiceDiscountDateList[1],

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
                InvoiceDiscountDate = invoiceDiscountDateList[2],

                InvoiceQuantity = invoiceQuantityList[2],
                InvoiceSku = invoiceSkuList[2],
                InvoiceDescription = invoiceDescriptionList[2],
                InvoicePrice = invoicePriceList[2],
                InvoicePST = invoicePSTList[2],
                InvoiceTotalPrice = invoiceTotalPriceList[2],

                InvoiceQuantity2 = invoiceQuantityList2[2],
                InvoiceSku2 = invoiceSkuList2[2],
                InvoiceDescription2 = invoiceDescriptionList2[2],
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

            invoices.Add(new Invoice
            {
                InvoiceNumber = invoiceNumberList[3],
                InvoiceDateTime = invoiceDateTimeList[3],
                InvoiceDiscount = invoiceDiscountList[3],
                InvoiceDiscountDate = invoiceDiscountDateList[3],

                InvoiceQuantity = invoiceQuantityList[3],
                InvoiceSku = invoiceSkuList[3],
                InvoiceDescription = invoiceDescriptionList[3],
                InvoicePrice = invoicePriceList[3],
                InvoicePST = invoicePSTList[3],
                InvoiceTotalPrice = invoiceTotalPriceList[3],

                InvoiceQuantity2 = invoiceQuantityList2[3],
                InvoiceSku2 = invoiceSkuList2[3],
                InvoiceDescription2 = invoiceDescriptionList2[3],
                InvoicePrice2 = invoicePriceList2[3],
                InvoicePST2 = invoicePSTList2[3],
                InvoiceTotalPrice2 = invoiceTotalPriceList2[3],

                InvoiceQuantity3 = invoiceQuantityList3[3],
                InvoiceSku3 = invoiceSkuList3[3],
                InvoiceDescription3 = invoiceDescriptionList3[3],
                InvoicePrice3 = invoicePriceList3[3],
                InvoicePST3 = invoicePSTList3[3],
                InvoiceTotalPrice3 = invoiceTotalPriceList3[3]
            });


            invoices.Add(new Invoice
            {
                InvoiceNumber = invoiceNumberList[4],
                InvoiceDateTime = invoiceDateTimeList[4],
                InvoiceDiscount = invoiceDiscountList[4],
                InvoiceDiscountDate = invoiceDiscountDateList[4],

                InvoiceQuantity = invoiceQuantityList[4],
                InvoiceSku = invoiceSkuList[4],
                InvoiceDescription = invoiceDescriptionList[4],
                InvoicePrice = invoicePriceList[4],
                InvoicePST = invoicePSTList[4],
                InvoiceTotalPrice = invoiceTotalPriceList[4],

                InvoiceQuantity2 = invoiceQuantityList2[4],
                InvoiceSku2 = invoiceSkuList2[4],
                InvoiceDescription2 = invoiceDescriptionList2[4],
                InvoicePrice2 = invoicePriceList2[4],
                InvoicePST2 = invoicePSTList2[4],
                InvoiceTotalPrice2 = invoiceTotalPriceList2[4],

                InvoiceQuantity3 = invoiceQuantityList3[4],
                InvoiceSku3 = invoiceSkuList3[4],
                InvoiceDescription3 = invoiceDescriptionList3[4],
                InvoicePrice3 = invoicePriceList3[4],
                InvoicePST3 = invoicePSTList3[4],
                InvoiceTotalPrice3 = invoiceTotalPriceList3[4]
            });


            invoices.Add(new Invoice
            {
                InvoiceNumber = invoiceNumberList[5],
                InvoiceDateTime = invoiceDateTimeList[5],
                InvoiceDiscount = invoiceDiscountList[5],
                InvoiceDiscountDate = invoiceDiscountDateList[5],

                InvoiceQuantity = invoiceQuantityList[5],
                InvoiceSku = invoiceSkuList[5],
                InvoiceDescription = invoiceDescriptionList[5],
                InvoicePrice = invoicePriceList[5],
                InvoicePST = invoicePSTList[5],
                InvoiceTotalPrice = invoiceTotalPriceList[5],

                InvoiceQuantity2 = invoiceQuantityList2[5],
                InvoiceSku2 = invoiceSkuList2[5],
                InvoiceDescription2 = invoiceDescriptionList2[5],
                InvoicePrice2 = invoicePriceList2[5],
                InvoicePST2 = invoicePSTList2[5],
                InvoiceTotalPrice2 = invoiceTotalPriceList2[5],

                InvoiceQuantity3 = invoiceQuantityList3[5],
                InvoiceSku3 = invoiceSkuList3[5],
                InvoiceDescription3 = invoiceDescriptionList3[5],
                InvoicePrice3 = invoicePriceList3[5],
                InvoicePST3 = invoicePSTList3[5],
                InvoiceTotalPrice3 = invoiceTotalPriceList3[5]
            }); 
            return invoices;           

        }

        static string GetValueOrEmpty(string[] items, int index)
        {
            string value = items.ElementAtOrDefault(index);
            if (value != null)
            {
                return value;
            }            
            else
            {
                return "";
            }
        }
    }
}

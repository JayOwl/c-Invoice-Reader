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
            using (StreamReader reader = new StreamReader("...\\...\\invoiceData.txt"))
            {
                string line;
                string readContents;
                //int invoices;
                int convertedInvoiceNumber;
                int invoiceNumber = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    readContents = reader.ReadToEnd();
                    String removedNewLines = readContents.Replace("\r", "");
                    String removedLines = removedNewLines.Replace("\n", "");
                    string[] getSectionByColon = removedLines.Split(':');


                    //foreach (string readDataByLine in getSectionByLine)
                    //{
                    //   string[] dataSectionByColon = readDataByLine.Split(':');
                    //}

                    invoiceNumber = Convert.ToInt32(getSectionByColon[0]);



                }
         
                reader.Close();  
                InvoiceCollection invoices = new InvoiceCollection();
                invoices.Add(new Invoice { InvoiceNumber = invoiceNumber });

                //invoicesString = invoices;
                return invoices;

            }

        }
    }
}

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
                int invoiceNumber = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    readContents = reader.ReadToEnd();
                    string[] dataSectionByLine = readContents.Split(':');
                    
                    invoiceNumber = Convert.ToInt32(dataSectionByLine[0]);
                    Console.WriteLine(invoiceNumber);
                            
     
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

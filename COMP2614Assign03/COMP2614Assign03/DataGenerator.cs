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
            DateTime invoiceDateTime;
            List<string> lines = new List<string>();
            List<int> invoiceList = new List<int>();
            List<DateTime> Inn = new List<DateTime>();
            using (StreamReader reader = new StreamReader("...\\...\\invoiceData.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    // Insert logic here.
                    // ... The "line" variable is a line in the file.
                    // ... Add it to our List.

                    lines.Add(line);
                    string[] splitLineByColon = line.Split(':');

                    invoiceNumber = Convert.ToInt32(splitLineByColon[0]);
                    invoiceList.Add(invoiceNumber);


                }

                int intInvoiceNumbers = 0;
                foreach (string value in lines)
                {
                    string invoiceNumbers;    


                }
            }


                //object getSectionByColon = null;
               

        InvoiceCollection invoices = new InvoiceCollection();
        invoices.Add(new Invoice { InvoiceNumber = invoiceList[0] });
        invoices.Add(new Invoice { InvoiceNumber = invoiceList[1] });
        invoices.Add(new Invoice { InvoiceNumber = invoiceList[2] });

            //invoicesString = invoices;
            return invoices;

            

        }
    }
}

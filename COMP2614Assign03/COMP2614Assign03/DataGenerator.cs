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
           // DateTime 
            List<string> lines = new List<string>();
            List<int> InvoiceNum = new List<int>();
            List<DateTime> In = new List<DateTime>();
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
                    InvoiceNum.Add(invoiceNumber);

                    //invoice

                    //Console.WriteLine(InvoiceNumbers[0]);

                }

                int intInvoiceNumbers = 0;
                foreach (string value in lines)
                {
                    string invoiceNumbers;    


                }
            }


                //object getSectionByColon = null;
               

        InvoiceCollection invoices = new InvoiceCollection();
        invoices.Add(new Invoice { InvoiceNumber = InvoiceNum[0] });
        invoices.Add(new Invoice { InvoiceNumber = InvoiceNum[1] });
        invoices.Add(new Invoice { InvoiceNumber = InvoiceNum[2] });

            //invoicesString = invoices;
            return invoices;

            

        }
    }
}

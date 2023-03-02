using SimpleFactoryClient;
using System;

namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactoryInterface objInvoice = null;
            int invoiceType = 0;
            Console.WriteLine("Enter the invoice type to be created-- 1 for with header 2 - withoutHeader ");
            invoiceType = Convert.ToInt32(Console.ReadLine());
            objInvoice = ClsFactory.getInvoice(invoiceType);
            objInvoice.Print();
        }
    }
}

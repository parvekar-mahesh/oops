using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryClient
{
    internal class ClsInvoiceWithoutHeader: IFactoryInterface
    {
        void IFactoryInterface.Print()
        {
            Console.WriteLine("Invoice without header is generated");
        }
    }
}

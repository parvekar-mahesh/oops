using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryClient
{
    internal class ClsInvoiceWithHeader : IFactoryInterface
    {
        void IFactoryInterface.Print()
        {
            Console.WriteLine("Invoice with header is generated");
        }
    }
}

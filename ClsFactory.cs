using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryClient
{
    internal class ClsFactory 
    {
        static public IFactoryInterface getInvoice(int invoiceType)
        {
            IFactoryInterface objInvoice = null;
            if (invoiceType==1)
            {
                objInvoice = new ClsInvoiceWithHeader();

            }
            else
            {
                objInvoice = new ClsInvoiceWithoutHeader();
            }

            return objInvoice;
        }
    }
}

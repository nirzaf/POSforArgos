using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using POSforArgos.DLL;
// These are auto generated

namespace POSforArgos.Business
{ 
    class ReceiptPrint
    {
        DataTable ds = new DataTable();
        SalesData sd = new SalesData();
        public DataTable Receipt(int InvoiceNo)
        {
            try
            {
                ds = sd.PrintInvoice(InvoiceNo);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

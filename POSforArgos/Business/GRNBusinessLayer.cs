using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POSforArgos.DLL;

namespace POSforArgos.Business
{
    class GRNBusinessLayer
    {
        GRNDataLayer grn = new GRNDataLayer();
        DataTable dt = new DataTable();
        public DataTable cmbCatLoad()
        {
            try
            {       
                dt = grn.loadCategoryCombo();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public DataTable cmbItemCode()
        {
            try
            {
                dt = grn.loadItemCodeCombo();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string ItemName(int ID)
        {
            try
            {
                string name = grn.ItemName(ID);
                return name;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AddStock(string Invoice_No, string Item_Code, int Received_Qty, string Received_Date, string Added_By)
        {
            try
            {
                string Message = grn.AddStock(Invoice_No,Item_Code,Received_Qty,Received_Date,Added_By);
                return Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable GetGRN()
        {
            try
            {
                return grn.GetGRN();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SearchGRN(string InvoiceNo)
        {
            try
            {
                return grn.SearchInvoice(InvoiceNo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

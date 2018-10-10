using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforArgos.DLL;
using System.Data;

namespace POSforArgos.Business
{
    class SalesBLL
    {
        SalesData sd = new SalesData();
        public string Invoice()
        {
            try
            {
                string invoice = sd.InvoiceNo();
                return invoice;
            }
            catch (Exception)
            {
                throw;
            }
        }

       public string AddSalesProduct (DataTable sales, int Transaction_ID)
        {
            string result;
            try
            {
                result = sd.AddSalesProduct(sales, Transaction_ID);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal DataTable SalesItems(string v, object itemCode)
        {
            throw new NotImplementedException();
        }

        public string AddSalesTransaction(int Transaction_ID, float Gross_Total, string Date, string Time, string LoyaltyCustomerID, int TransactionQty, string Cashier_Name)
        {
            string result;
            try
            {
                result = sd.AddSalesTransaction(Transaction_ID, Gross_Total, Date, Time, LoyaltyCustomerID, TransactionQty, Cashier_Name);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable SalesItems(string Item_Code)
        {
            try
            {
                DataTable dt = sd.SalesItems(Item_Code);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ItemQty(string Item_Code)
        {
            try
            {
                DataTable dt = sd.ItemQty(Item_Code);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable InvoiceNo(int Transaction_ID)
        {
            try
            {
                DataTable dt = sd.InvoiceNo(Transaction_ID);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ContNo(string Contact)
        {
            try
            {
                DataTable dt = sd.ContNo(Contact);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable DailyTransactionSummary(string Date)
        {
            try
            {
                DataTable dt = sd.DailyTransactionSummary(Date);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable IncomeReport(string FromDate, string ToDate)
        {
            try
            {
                DataTable dt = sd.IncomeReport(FromDate, ToDate);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

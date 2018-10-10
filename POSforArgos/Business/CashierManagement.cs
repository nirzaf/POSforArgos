using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforArgos.DLL;

namespace POSforArgos.Business
{
    class CashierManagement
    {
        ManageCashierData obj = new ManageCashierData();

        public DataTable GetCashier()
        {
            try
            {
                return obj.GetCashier();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AddCashier(string username, string password)
        {
            try
            {
                string Message = obj.InsertCashier(username, password);
                return Message;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                return Message;
            }
        }

        public string DeleteCashier(string username)
        {
            string Message=null;
            try
            {
                Message = obj.DeleteCashier(username);
                return Message;
            }
            catch (Exception ex)
            {
                return Message = ex.Message;
            }    
        }

        public string UpdateCashier(string username, string password)
        {
            try
            {
                string Message = obj.UpdateCashier(username, password);
                return Message;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                return Message;
            }
        }

        public DataTable SearchCashier(string cName)
        {
            try
            {
                return obj.SearchCashier(cName);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

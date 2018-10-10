using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforArgos.DLL;
using System.Data.SqlClient;
using System.Data;

namespace POSforArgos.Business
{
    class ManageCustomerBL
    {
        CustomerData cd = new CustomerData();

        public DataTable GetCustomers()
        {
            try
            {
                return cd.GetCustomers();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string UpdatePoints(string ContactNo, float Points)
        {
            try
            {
                string message = "";
                message = cd.UpdatePoints(ContactNo, Points);
                return message;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AddCustomer(string ContactNo, string FullName, string Address)
        {
            try
            {
                string Message = cd.AddCustomer(ContactNo,FullName,Address);
                return Message;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                return Message;
            }
        }

        public string DeleteCustomer(string ContactNo)
        {
            string Message = null;
            try
            {
                Message = cd.DeleteCustomer(ContactNo);
                return Message;
            }
            catch (Exception ex)
            {
                return Message = ex.Message;
            }
        }

        public string UpdateCustomer(string ContactNo,string FullName, string Address)
        {
            try
            {
                string Message = cd.UpdateCustomers(ContactNo, FullName, Address);
                return Message;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                return Message;
            }
        }

        public DataTable SearchCustomer(string Contact)
        {
            try
            {
                return cd.SearchCustomer(Contact);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SelectCustomer(string ContactNo)
        {
            try
            {
                bool valid = cd.SelectCustomer(ContactNo);
                if (valid == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void UpdateCustomer(string contact)
        {
            throw new NotImplementedException();
        }
    }
}

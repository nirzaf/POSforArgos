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
   
    class LoginAuth
    {
        LoginDataAccess obj = new LoginDataAccess();

        public int Admin_Auth(string username, string password)
        {
            try
            {
                int value = obj.AdminLogin(username,password);
                return value;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Cashier_Auth(string username, string password)
        {
            try
            {
                int value = obj.CashierLogin(username, password);
                return value;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

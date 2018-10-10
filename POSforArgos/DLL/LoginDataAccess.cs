using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace POSforArgos.DLL
{
    public class LoginDataAccess
    {
        DataCon newCon = new DataCon();

        public int AdminLogin(string username, string password)
        {
            int value = 0;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand check_auth = new SqlCommand("SELECT * FROM Admin WHERE username = '" + username + "' and password = '" + password + "'", newCon.Con);
                SqlDataReader reader = check_auth.ExecuteReader();
                if (reader.HasRows)
                {
                    value = 1;
                    return value;
                }
                else
                {
                    return value;
                }
            }
            catch
            {
                throw;
            }
        }

        public int CashierLogin(string username, string password)
        {
            int value = 0;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand check_auth = new SqlCommand("SELECT * FROM Cashier WHERE username = '" + username + "' and password = '" + password + "'", newCon.Con);
                SqlDataReader reader = check_auth.ExecuteReader();
                if (reader.HasRows)
                {
                    value = 1;
                    return value;
                }
                else
                {
                    return value;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

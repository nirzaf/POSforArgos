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
    class ManageCashierData
    {
        DataTable dt = new DataTable();
        DataCon newCon = new DataCon();

        public string InsertCashier(string cName, string cPassword)
        {
            string Message = null;
            try
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT * FROM Admin WHERE ([username] = @cName)", newCon.Con);
                check_User_Name.Parameters.AddWithValue("@cName", cName);
                SqlDataReader reader = check_User_Name.ExecuteReader();
                if (reader.HasRows)
                {
                    try
                    {
                        Message = "Given username exists already";
                        return Message;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Message = ex.Message;
                        return Message;
                    }
                }
                else
                {
                    reader.Close();
                    try
                    {
                        if (ConnectionState.Closed == newCon.Con.State)
                        {
                            newCon.Con.Open();
                        }
                        dt.Clear();
                        SqlDataAdapter adp = new SqlDataAdapter("INSERT INTO Cashier VALUES ('" + cName + "','" + cPassword + "')", newCon.Con);
                        adp.Fill(dt);
                        Message = "Succesfully Added";
                        return Message;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message;
                        return Message;
                    }

                }
            }
            catch (Exception ex)
            {
                Message = ex.Message; 
            }
            return Message;
        }

        public DataTable GetCashier()
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter cmdCat = new SqlDataAdapter("Select * From Cashier", newCon.Con);
                cmdCat.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        
        public string UpdateCashier(string cName, string cPassword)
        {
            string Message = null;
            try
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT * FROM Cashier WHERE ([username] = @cName)", newCon.Con);
                check_User_Name.Parameters.AddWithValue("@cName", cName);
                SqlDataReader reader = check_User_Name.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    try
                    {
                        try
                        {
                            if (ConnectionState.Closed == newCon.Con.State)
                            {
                                newCon.Con.Open();
                            }
                            dt.Clear();
                            SqlDataAdapter adp = new SqlDataAdapter("Update Cashier set password = ('" + cPassword + "') Where username = '" + cName + "'", newCon.Con);
                            adp.Fill(dt);
                            Message = "Succesfully Updated";
                            return Message;
                        }
                        catch (Exception ex)
                        {
                            Message = ex.Message;
                            return Message;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Message = ex.Message;
                        return Message;
                    }
                }
                else
                {
                    reader.Close();
                    Message = "You cannot update the username";
                    return Message;
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            return Message;

        }

        public string DeleteCashier(string cName)
        {
            string Message = null;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand adp = new SqlCommand("Delete From Cashier Where username = ('" + cName + "')", newCon.Con);
                adp.ExecuteNonQuery();
                return Message = "Successfully Deleted";
            }
            catch (Exception ex)
            {
                return Message = ex.Message;
            }
        }

        public DataTable SearchCashier(string cName)
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter cmdCat = new SqlDataAdapter("SELECT * FROM Cashier WHERE username like '%" + cName + "%'", newCon.Con);
                cmdCat.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

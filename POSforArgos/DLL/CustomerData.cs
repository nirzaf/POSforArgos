using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POSforArgos.DLL
{
    class CustomerData
    {
        DataTable dt = new DataTable();
        DataCon newCon = new DataCon();

        public string AddCustomer(string Contact , string FullName, string Address)
        {
            string Message = null;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                    SqlCommand check_Contact_No = new SqlCommand("SELECT * FROM Customer WHERE Contact_No = @Contact", newCon.Con);
                    check_Contact_No.Parameters.AddWithValue("@Contact", Contact);
                    SqlDataReader reader = check_Contact_No.ExecuteReader();

                    if (reader.HasRows)
                    {
                        try
                        {
                            Message = "Given contact no exists already";
                            reader.Close();
                            return Message;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Message = ex.Message;
                            reader.Close();
                            return Message;
                        }
                    }
                    else
                    {
                        try
                        {
                            if (ConnectionState.Closed == newCon.Con.State)
                            {
                                newCon.Con.Open();
                            }
                            dt.Clear();
                            SqlDataAdapter adp = new SqlDataAdapter("INSERT INTO Customer VALUES ('" + Contact + "','" + FullName + "','" + Address + "','" + 0 + "' )", newCon.Con);
                            adp.Fill(dt);
                            Message = "Succesfully Added";
                            reader.Close();
                            newCon.Con.Close();
                            return Message;
                        }
                        catch (Exception ex)
                        {
                            Message = ex.Message;
                            reader.Close();
                            newCon.Con.Close();
                            return Message;
                        }
                    }
                }
                else
                {
                    try
                    {
                        SqlCommand check_Contact_No = new SqlCommand("SELECT * FROM Customer WHERE Contact_No = @Contact", newCon.Con);
                        check_Contact_No.Parameters.AddWithValue("@Contact", Contact);
                        SqlDataReader reader = check_Contact_No.ExecuteReader();

                        if (reader.HasRows)
                        {
                            try
                            {
                                Message = "Given contact no exists already";
                                reader.Close();
                                return Message;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                Message = ex.Message;
                                reader.Close();
                                return Message;
                            }
                        }
                        else
                        {
                            dt.Clear();
                            SqlDataAdapter adp = new SqlDataAdapter("INSERT INTO Customer VALUES ('" + Contact + "','" + FullName + "','" + Address + "','" + 0 + "' )", newCon.Con);
                            adp.Fill(dt);
                            Message = "Succesfully Added";
                            newCon.Con.Close();
                            return Message;
                        }
                    }
                    catch (Exception ex)
                    {
                        newCon.Con.Close();
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

        public DataTable GetCustomers()
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                DataRow dr;
                SqlDataAdapter cmdCat = new SqlDataAdapter("SELECT * From Customer", newCon.Con);
                cmdCat.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public string UpdateCustomers(string Contact, string FullName, string Address)
        {
            string Message = null;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlDataAdapter adp = new SqlDataAdapter("Update Customer set Full_Name = ('" + FullName + "'), Address = ('" + Address + "') Where Contact_No = '" + Contact + "'", newCon.Con);
                adp.Fill(dt);
                newCon.Con.Close();
                Message = "Succesfully Updated";
                return Message;
            }
            catch (Exception ex)
            {
                if (ConnectionState.Open == newCon.Con.State)
                {
                    newCon.Con.Close();
                }
                Message = ex.Message;
                return Message;
            }
        }

        public string UpdatePoints(string ContactNo, float Points)
        {

            string cont = ContactNo;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand adp = new SqlCommand("Update Customer SET Loyalty_Points = Loyalty_Points + '" + Points + "' Where Contact_No = '" + cont + "'", newCon.Con);
                adp.ExecuteNonQuery();
                newCon.Con.Close();
                string message = "Succesfully Updated";
                return message;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string DeleteCustomer(string ContactNo)
        {
            string Message = null;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand adp = new SqlCommand("Delete From Customer Where Contact_No = ('" + ContactNo + "')", newCon.Con);
                adp.ExecuteNonQuery();
                return Message = "Successfully Deleted";
            }
            catch (Exception ex)
            {
                return Message = ex.Message;
            }
        }

        public DataTable SearchCustomer(string ContactNo)
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter cmdCat = new SqlDataAdapter("SELECT * FROM Customer WHERE Contact_No like '%" + ContactNo + "%'", newCon.Con);
                cmdCat.Fill(dt);
                return dt;
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
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE Contact_No= '" + ContactNo + "'", newCon.Con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

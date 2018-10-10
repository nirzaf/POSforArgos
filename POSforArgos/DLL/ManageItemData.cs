using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POSforArgos.DLL
{
    class ManageItemData
    {
        DataTable dt = new DataTable();
        DataCon newCon = new DataCon();

        public string AddItem(string ItemCode, string ItemName, float UnitPrice, int ItemCategory)
        {
            string Message = null;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                    SqlCommand check_Item_Code = new SqlCommand("SELECT * FROM Item_Stock WHERE ([Item_Code] = @Item_Code)", newCon.Con);
                    check_Item_Code.Parameters.AddWithValue("@Item_Code", ItemCode);
                    SqlDataReader reader = check_Item_Code.ExecuteReader();

                    if (reader.HasRows)
                    {
                        try
                        {
                            Message = "Given item code exists already";
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
                            SqlCommand cmd = new SqlCommand("AddItems", newCon.Con)
                            {
                                CommandType = CommandType.StoredProcedure
                            };
                            cmd.Parameters.AddWithValue("@Item_Code", ItemCode);
                            cmd.Parameters.AddWithValue("@Item_Name", ItemName);
                            cmd.Parameters.AddWithValue("@Unit_Price", UnitPrice);
                            cmd.Parameters.AddWithValue("@Category", ItemCategory);
                            cmd.ExecuteNonQuery();
                         //   SqlDataAdapter da = new SqlDataAdapter(cmd);
                            Message = "Succesfully Added";
                            reader.Close();
                            return Message;
                        }
                        catch (Exception ex)
                        {
                            reader.Close();
                            Message = ex.Message;
                            return Message;
                        }
                    }
                }
                else
                {
                    try
                    {
                        SqlCommand check_Item_Code = new SqlCommand("SELECT * FROM Item_Stock WHERE ([Item_Code] = @Item_Code)", newCon.Con);
                        check_Item_Code.Parameters.AddWithValue("@Item_Code", ItemCode);
                        SqlDataReader reader = check_Item_Code.ExecuteReader();

                        if (reader.HasRows)
                        {
                            try
                            {
                                Message = "Given item code exists already";
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
                            SqlCommand cmd = new SqlCommand("AddItems",newCon.Con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Item_Code", ItemCode);
                            cmd.Parameters.AddWithValue("@Item_Name", ItemName);
                            cmd.Parameters.AddWithValue("@Unit_Price", UnitPrice);
                            cmd.Parameters.AddWithValue("@Category", ItemCategory);
                            cmd.ExecuteNonQuery();
                           // SqlDataAdapter da = new SqlDataAdapter(cmd);
                            Message = "Succesfully Added";
                            newCon.Con.Close();
                            return Message;
                        }
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message;
                        newCon.Con.Close();
                        return Message;
                    }
                }
            }
            catch (Exception ex)
            {
                newCon.Con.Close();
                Message = ex.Message;
            }
            return Message;
        }

        public DataTable GetItems()
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter cmdCat = new SqlDataAdapter("SELECT Item_Stock.Item_Code, Item_Stock.Item_Name, Item_Stock.Unit_Price, Category.Category FROM Item_Stock INNER JOIN Category ON Item_Stock.Category = Category.Cat_ID", newCon.Con);          
                cmdCat.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public string UpdateItem(string ItemCode, string ItemName, float UnitPrice,int Cat_ID)
        {
            string Message = null;
            try
            {
                    if (ConnectionState.Closed == newCon.Con.State)
                    {
                        newCon.Con.Open();
                    }
       
                    SqlCommand check_Item_Code = new SqlCommand("SELECT * FROM Item_Stock WHERE ([Item_Code] = @Item_Code and [Category] = @Category)", newCon.Con);
                    check_Item_Code.Parameters.AddWithValue("@Item_Code", ItemCode);
                    check_Item_Code.Parameters.AddWithValue("@Category", Cat_ID);
                    SqlDataReader reader = check_Item_Code.ExecuteReader();
                    if (reader.HasRows)
                    {
                        try
                        {
                            if (ConnectionState.Closed == newCon.Con.State)
                            {
                                newCon.Con.Open();
                            }
                                dt.Clear();
                                SqlDataAdapter adp = new SqlDataAdapter("Update Item_Stock set Item_Name = ('" + ItemName + "'), Unit_Price = ('" + UnitPrice + "') Where Item_Code = '" + ItemCode + "' and Category = '" + Cat_ID + "'", newCon.Con);
                                adp.Fill(dt);
                            if (ConnectionState.Open == newCon.Con.State)
                            {
                                newCon.Con.Close();
                            }
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
                    else
                    {
                        Message = "You cannot update the Item Code and Category";
                        if (ConnectionState.Open == newCon.Con.State)
                        {
                            newCon.Con.Close();
                        }
                    return Message;
                    }
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

        public string DeleteItem(string ItemCode)
        {
            string Message = null;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand adp = new SqlCommand("Delete From Item_Stock Where Item_Code = ('" + ItemCode + "')", newCon.Con);
                SqlCommand ap = new SqlCommand("Delete From Stock Where Item_Code = ('" + ItemCode + "')", newCon.Con);
                adp.ExecuteNonQuery();
                ap.ExecuteNonQuery();
                return Message = "Successfully Deleted";
            }
            catch (Exception ex)
            {
                return Message = ex.Message;
            }
        }

        public DataTable SearchItems(string ItemName)
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter cmdCat = new SqlDataAdapter("SELECT * FROM Item_Stock WHERE Item_Name like '%" + ItemName + "%'", newCon.Con);
                cmdCat.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetItemTransaction(string Item_Code)
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }   
                dt.Clear();
                SqlDataAdapter cmdCat = new SqlDataAdapter("SELECT Item_Stock.Item_Code, Item_Stock.Item_Name, Item_Stock.Unit_Price, Category.Category FROM Item_Stock INNER JOIN Category ON Item_Stock.Category = Category.Cat_ID WHERE Item_Stock.Item_Code = '"+Item_Code+"' ", newCon.Con);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforArgos.View;

namespace POSforArgos.DLL
{
    class SalesData
    {
        DataCon newCon = new DataCon();
        public string msg = "Transaction Added";


        //function to generate invoice no
        public string InvoiceNo()
        {
            if (ConnectionState.Closed == newCon.Con.State)
            {
                newCon.Con.Open();
            }

            string query = "Select max(Transaction_ID) From Sales_Product";
            SqlCommand cmd = new SqlCommand(query, newCon.Con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string invoice = dr[0].ToString();
                if (invoice == "")
                {
                    invoice = "1";
                    return invoice;
                }
                else
                {
                    return invoice;
                }
            }
            else
            {
                string message = "Something Went wrong";
                return message;
            }
        }

        //Function to add sales transaction
        public string AddSalesTransaction(int Transaction_ID, float Gross_Total, string Date, string Time, string LoyaltyCustomerID, int TransactionQty, string Cashier_Name)
        {
            try
            {
                   SqlCommand sda = new SqlCommand(@"INSERT into Sales_Transaction(Transaction_ID,Date,Time,Quantity,Gross_Total,Cashier_Name,LoyaltyCustomerID)
                                        Values(@Transaction_ID, @Date, @Time, @Quantity, @Gross_Total, @Cashier_Name, @LCID )",newCon.Con);
 
                      sda.Parameters.AddWithValue("@Transaction_ID", Transaction_ID);
                      sda.Parameters.AddWithValue("@Date", Date);
                      sda.Parameters.AddWithValue("@Time",Time);
                      sda.Parameters.AddWithValue("@Quantity", TransactionQty);
                      sda.Parameters.AddWithValue("@Gross_Total",Gross_Total);
                      sda.Parameters.AddWithValue("@Cashier_Name", Cashier_Name);
                      sda.Parameters.AddWithValue("@LCID", LoyaltyCustomerID);
                    if (ConnectionState.Closed == newCon.Con.State)
                        {
                            newCon.Con.Open();
                        }
                        sda.ExecuteNonQuery();
                    string msg = "added";
                    return msg;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // add sales product
        public string AddSalesProduct(DataTable sales, int Transaction_ID)
        {
            try
            {
                SqlCommand sda = new SqlCommand();
                foreach (DataRow dr in sales.Rows)
                {
                    if (ConnectionState.Closed == newCon.Con.State)
                    {
                        newCon.Con.Open();
                    }
                    sda = new SqlCommand(@"INSERT into Sales_Product(Transaction_ID, Product_Name, Quantity, Price,Gross_Total)
                                        Values(@Transaction_ID, @Product_Name,@Quantity,@Price,@Gross_Total)", newCon.Con);
                    SqlCommand cmd = new SqlCommand("UPDATE Stock SET Quantity = Quantity - '" + Convert.ToInt32(dr[4].ToString()) + "' WHERE Item_Code = '" + dr[1].ToString() + "'", newCon.Con);
                    sda.Parameters.AddWithValue("@Transaction_ID", Transaction_ID);
                    sda.Parameters.AddWithValue("@Product_Name", dr[2].ToString());
                    sda.Parameters.AddWithValue("@Quantity", Convert.ToInt32(dr[4].ToString()));
                    sda.Parameters.AddWithValue("@Price", Convert.ToSingle(dr[3].ToString()));
                    sda.Parameters.AddWithValue("@Gross_Total", Convert.ToSingle(dr[6].ToString()));   
                    cmd.ExecuteNonQuery();
                    int count = sda.ExecuteNonQuery();
                    if (count > 0)
                    {
                        msg = "Transaction Added";
                    }
                }
                return msg;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //function to generate sales Items
        public DataTable SalesItems (string ItemCode)
        {
            if (ConnectionState.Closed == newCon.Con.State)
            {
                newCon.Con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT Item_Stock.Item_Code, Item_Stock.Item_Name, Item_Stock.Unit_Price, Category.Category FROM Item_Stock INNER JOIN Category ON Item_Stock.Category = Category.Cat_ID WHERE Item_Stock.Item_Code = '" + ItemCode + "' ", newCon.Con);
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        //function to get item quantity 
        public DataTable ItemQty(string ItemCode)
        {
            if (ConnectionState.Closed == newCon.Con.State)
            {
                newCon.Con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * From Stock Where Item_Code = '" + ItemCode + "' ", newCon.Con);
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        //get function invoice no 
        public DataTable InvoiceNo(int Transaction_ID)
        {
            if (ConnectionState.Closed == newCon.Con.State)
            {
                newCon.Con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * From Sales_Transaction Where Transaction_ID = '" + Transaction_ID + "' ", newCon.Con);
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }
        }


        // get loyalty customer by contact no
        public DataTable ContNo(string Contact)
        {
            if (ConnectionState.Closed == newCon.Con.State)
            {
                newCon.Con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * From Sales_Transaction Where LoyaltyCustomerID = '" + Contact + "' ", newCon.Con);
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        //Daily transaction summary function
        public DataTable DailyTransactionSummary(string Date)
        {
            if (ConnectionState.Closed == newCon.Con.State)
            {
                newCon.Con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * From Sales_Transaction Where Date = '" + Date + "' ", newCon.Con);
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        //Income report function
        public DataTable IncomeReport(string FromDate, string ToDate)
        {
            if (ConnectionState.Closed == newCon.Con.State)
            {
                newCon.Con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * From Sales_Transaction Where Date BETWEEN '" + FromDate + "' AND '"+ ToDate+"' ", newCon.Con);
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }

        }

        //get result by transaction ID
        public DataTable PrintInvoice(int Transaction_ID)
        {
            if (ConnectionState.Closed == newCon.Con.State)
            {
                newCon.Con.Open();
            }
            SqlDataAdapter cmd = new SqlDataAdapter(@"SELECT * From Sales_Product Where Transaction_ID = '" + Transaction_ID + "'", newCon.Con);
            DataTable dt = new DataTable();
            try
            {
                cmd.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }
    }
}

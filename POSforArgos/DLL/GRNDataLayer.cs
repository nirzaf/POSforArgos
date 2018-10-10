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
    class GRNDataLayer
    {
        DataCon newCon = new DataCon();
        DataTable dt = new DataTable();
        public DataTable loadCategoryCombo()
        {
            try
            {
                string sql;
                sql = "Select * from Category";
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter(sql, newCon.Con);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public DataTable loadItemCodeCombo()
        {
            try
            {
                string sql;
                sql = "Select * from Item_Stock";
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter(sql, newCon.Con);
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public string ItemName(int ItemCode)
        {
            string ItemName=null;
            try
            {
                string sql;
                sql = "Select Item_Name from Item_Stock Where Item_Code = '"+ItemCode+"'";
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand cmd = new SqlCommand(sql,newCon.Con);
                SqlDataReader item = cmd.ExecuteReader();
                ItemName = item.ToString();
                return ItemName;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AddStock(string Invoice_No, string Item_Code, int Received_Qty, string Received_Date, string Added_By)
        {
            string Message = null;
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand cmd1 = new SqlCommand("INSERT INTO GRN_Note (Invoice_Number,Item_Code, Received_Qty, Received_Date, Added_by) VALUES ('" + Invoice_No + "','" + Item_Code + "','" + Received_Qty + "','" + Received_Date + "','" + Added_By + "')", newCon.Con);
                SqlCommand cmd2 = new SqlCommand("UPDATE Stock SET Quantity = Quantity + '" + Received_Qty + "' WHERE Item_Code = '" + Item_Code + "'", newCon.Con);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                Message = "Succesfully Added";
                return Message;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return Message;
            }
        }

        public DataTable GetGRN()
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter cmdCat = new SqlDataAdapter(@"SELECT GRN_Note.Invoice_Number, GRN_Note.Received_Date, GRN_Note.Received_Qty, GRN_Note.Item_Code AS Expr2, GRN_Note.Added_By, Item_Stock.Item_Code, Item_Stock.Category, Item_Stock.Item_Name, 
                         Category.Category AS Expr1, Category.Cat_ID, Item_Stock.Unit_Price
FROM            GRN_Note INNER JOIN
                         Item_Stock ON GRN_Note.Item_Code = Item_Stock.Item_Code INNER JOIN
                         Category ON Item_Stock.Category = Category.Cat_ID", newCon.Con);
                cmdCat.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SearchInvoice(string Invoice)
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter cmd = new SqlDataAdapter(@"SELECT GRN_Note.Invoice_Number, GRN_Note.Received_Date, GRN_Note.Received_Qty, GRN_Note.Item_Code AS Expr2, GRN_Note.Added_By, Item_Stock.Item_Code, Item_Stock.Category, Item_Stock.Item_Name, 
                         Category.Category AS Category_Name, Category.Cat_ID, Item_Stock.Unit_Price
FROM            GRN_Note INNER JOIN
                         (Item_Stock ON GRN_Note.Item_Code = Item_Stock.Item_Code INNER JOIN
                         Category ON Item_Stock.Category = Category.Cat_ID) WHERE GRN.Note.Invoice_Number like '%" + Invoice + "%'", newCon.Con);
                cmd.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

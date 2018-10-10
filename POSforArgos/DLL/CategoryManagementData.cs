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
    public class CategoryManagementData
    {
        DataTable dt = new DataTable();
        DataCon newCon = new DataCon();

        public void InsertCategory(string cName)
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter adp = new SqlDataAdapter("INSERT INTO Category VALUES ('"+cName+"')", newCon.Con);
                adp.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable GetCategory()
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter cmdCat = new SqlDataAdapter("Select * From Category", newCon.Con);
                cmdCat.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateCategory(int Cat_ID,string cName)
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                dt.Clear();
                SqlDataAdapter adp = new SqlDataAdapter("Update Category set Category = ('" + cName + "') Where Cat_ID = '"+Cat_ID+"'" , newCon.Con);
                adp.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void DeleteCategory(int Cat_ID)
        {
            try
            {
                if (ConnectionState.Closed == newCon.Con.State)
                {
                    newCon.Con.Open();
                }
                SqlCommand adp = new SqlCommand("Delete From Category Where Cat_ID = ('" + Cat_ID + "')", newCon.Con);
                adp.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

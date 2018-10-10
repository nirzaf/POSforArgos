using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using POSforArgos.DLL;
using System.Data.SqlClient;

namespace POSforArgos.Business
{
    public class CategoryManagement
    {
        CategoryManagementData obj = new CategoryManagementData();

        public DataTable GetCategory()
        {
            try
            {      
                return obj.GetCategory();
            }
            catch (Exception)
            {
                throw;
            }

        }
            
        public void InsertCategory(String cName)
        {
            try
            {
                obj.InsertCategory(cName);
            }
            catch
            {
                throw;
            }

        }

        public void UpdateCategory(int ID, string cName)
        {
            try
            {
                obj.UpdateCategory(ID, cName);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteCategory(int Cat_ID)
        {
            try
            {
                obj.DeleteCategory(Cat_ID);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

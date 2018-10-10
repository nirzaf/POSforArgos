using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforArgos.DLL;

namespace POSforArgos.Business
{
    class ManageItems
    {
        ManageItemData obj = new ManageItemData();

        public class MyObj
        {
            public string Item_Code { get; set; }
            public string Item_Name { get; set; }
            public float Unit_Price { get; set; }
            public int Category { get; set; }
        }

        

        public List<MyObj> GetItem(String ItemCode)
        {
            DataTable dt = obj.GetItemTransaction(ItemCode);

            var convertedList = (from rw in dt.AsEnumerable()
                                 select new MyObj()
                                 {
                                     Item_Code = Convert.ToString(rw["Item_Code"]),
                                     Item_Name = Convert.ToString(rw["Item_Name"]),
                                     Unit_Price = float.Parse(Convert.ToString(rw["Quantity"])),
                                     Category = Convert.ToInt32(rw["Category"])
                                 }).ToList();

            return convertedList;
        }

        public DataTable GetItems()
        {
            try
            {
                return obj.GetItems();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AddItems(string ItemCode, string ItemName, float UnitPrice, int Category)
        {
            try
            {
                string Message = obj.AddItem(ItemCode,ItemName,UnitPrice,Category);
                return Message;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                return Message;
            }
        }

        public string DeleteItem(string ItemCode)
        {
            string Message = null;
            try
            {
                Message = obj.DeleteItem(ItemCode);
                return Message;
            }
            catch (Exception ex)
            {
                return Message = ex.Message;
            }
        }

        public string UpdateItem(string ItemCode, string ItemName, float UnitPrice,int Cat_ID)
        {
            try
            {
                string Message = obj.UpdateItem(ItemCode,ItemName,UnitPrice,Cat_ID);
                return Message;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                return Message;
            }
        }

        public DataTable SearchItems(string ItemName)
        {
            try
            {
                return obj.SearchItems(ItemName);
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
                return obj.GetItemTransaction(Item_Code);
            }
            catch (Exception)
            {
                throw;
            }
        }   
    }
}

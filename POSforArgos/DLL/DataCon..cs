using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POSforArgos.DLL
{
    public class DataCon
    {
          public  SqlConnection Con = new SqlConnection("Data Source=NIRZAF\\SQLEXPRESS01;Initial Catalog=myPosDb;Integrated Security=True; MultipleActiveResultSets=True;");
    }
}

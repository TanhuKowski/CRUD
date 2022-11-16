using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CRUD
{
    internal class Server_Source
    {
         private static string conn ="Data Source=MSI\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        public static string Get_Conn()
        {
            return conn;
        }
    }
}

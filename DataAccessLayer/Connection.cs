using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ControlVentas.DataAccessLayer
{
    internal static class Connection
    {
        private static string connectionChain = "Server= DESKTOP-4MKOKSM; Database=SalesControl; Integrated Security=true;";
        public static SqlConnection connection = new SqlConnection(connectionChain);

        public static void open()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public static void close()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

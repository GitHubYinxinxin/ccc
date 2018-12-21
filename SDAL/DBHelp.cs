using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SDAL
{
    public class DBHelp
    {
        private static string connStr = "Data Source=.;Initial Catalog=T_User;Integrated Security=True";
        public static bool Write(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            return rs > 0;
        }
        public static DataTable Read(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, connStr);
            dap.Fill(table);
            return table;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAL
{
    public class UserDAL
    {
        public static bool UserLogin(string name,string pwd)
        {
            string sql = string.Format("select * from T_user where Name = '{0}' and Pwd = '{1}'",name,pwd);
            var table = DBHelp.Read(sql);
            return table.Rows.Count > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAL
{
    public class ZhuCeDAL
    {
        public static bool UserZhuCe(string name,int age,string gender,int mobiel,string pwd)
        {
            string sql = string.Format("insert T_user vlues('{0}','{1}','{2}','{3}','{4}')", name, age, gender, mobiel, pwd);
            var table = DBHelp.Write(sql);
            return table;
        }
    }
}

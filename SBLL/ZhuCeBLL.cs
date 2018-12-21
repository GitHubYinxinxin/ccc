using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDAL;

namespace SBLL
{
    public class ZhuCeBLL
    {
        public static bool UserZhuCe(string name, int age, string gender, int mobiel, string pwd)
        {
            if (name == "" || age.ToString() == "" || gender == "" || mobiel.ToString() == "" || pwd == "")
            {
                return false;
            }
            if (age <= 0 || age >= 100)
            {
                return false;
            }
            if (gender != "男" || gender != "女")
            {
                return false;
            }
            return ZhuCeDAL.UserZhuCe(name, age, gender, mobiel, pwd);
        }
    }
}

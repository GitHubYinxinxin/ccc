using SDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBLL
{
    public class UserBLL
    {
        public static bool UserLogin(string name,string pwd)
        {
            if (name == "" || pwd == "")
            {
                return false;
            }
            return UserDAL.UserLogin(name,pwd);
        }
    }
}

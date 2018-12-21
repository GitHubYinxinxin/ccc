using SBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SanCeng
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text;
            string pwd = this.txt_pwd.Text;

            if (UserBLL.UserLogin(name, pwd))
            {
                Response.Write("<script>alert('登陆成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('登陆失败')</script>");
            }
            
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 }
    }
}
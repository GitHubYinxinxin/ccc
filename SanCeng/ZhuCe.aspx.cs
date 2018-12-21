using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SBLL;

namespace SanCeng
{
    public partial class ZhuCe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text;
            int age = int.Parse(this.txt_age.Text);
            string gender = this.txt_gender.Text;
            int mobiel = int.Parse(this.txt_mobiel.Text);
            string pwd = this.txt_pwd.Text;

            if (ZhuCeBLL.UserZhuCe(name, age, gender, mobiel, pwd))
            {
                Response.Write("<script></script>")
            }

        }
    }
}
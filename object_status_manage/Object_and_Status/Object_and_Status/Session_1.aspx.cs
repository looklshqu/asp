using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Session_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sw = 0;
            string[,] idInfo = new string[,]
            {
                {"looklsh", "look3834" },
                {"lshahk", "icetea3834" }
            };
            for (int i = 0; i < idInfo.GetLength(1); i++) // length: 행수 * 열수 
            {
                if (idInfo[i,0] == TextBox1.Text && idInfo[i,1] == TextBox2.Text)
                {
                    sw = 1;
                    break;
                }
            }
            if (sw == 1)
            {
                Session["id"] = TextBox1.Text;
                Session["password"] = TextBox2.Text;
                Response.Redirect("Session_1_result.aspx");
            }
            else
            {
                Response.Write("<script>alert('id 또는 비밀번호가 올바르지 않습니다.');history.back();</script>");
            }
            
        }
    }
}
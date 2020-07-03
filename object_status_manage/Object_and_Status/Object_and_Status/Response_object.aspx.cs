using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Response_object : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(DateTime.Now.ToString("yyyy-MM-dd"));
            Response.Write("에 남긴 메시지: " + TextBox1.Text);
            //Response.Flush();
            //Response.Clear();
            Response.End();
            Response.Write("고객님 성원에 감사합니다.");
        }
    }
}
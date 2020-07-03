using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Session_1_result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "id " + Session["id"] + Environment.NewLine + " 비밀번호 " + Session["password"] + " 접속하셨습니다. ";
        }
    }
}
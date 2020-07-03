using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status.TestServer
{
    public partial class Server_method : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Server.MapPath("."); //현재 경로
            TextBox2.Text = Server.MapPath("~"); //루트 경로
        }
    }
}
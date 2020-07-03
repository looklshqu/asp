using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Server_transfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Server.Transfer("Server_transfer_main.aspx");
            Response.Redirect("Server_transfer_main.aspx");
        }
    }
}
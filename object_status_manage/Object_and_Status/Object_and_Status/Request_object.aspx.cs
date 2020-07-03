using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Request_object : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Request.UserHostAddress;
            HttpBrowserCapabilities Browser = Request.Browser;
            TextBox2.Text = Browser.Type;
            TextBox3.Text = Browser.Platform;
        }
    }
}
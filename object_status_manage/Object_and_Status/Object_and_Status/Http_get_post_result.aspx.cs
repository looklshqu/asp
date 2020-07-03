using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Http_get_post_result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Request.QueryString["irum"];
            Label1.Text = Request["irum"];
            //Label2.Text = Request.QueryString["email"];
            Label2.Text = Request["email"];
        }
    }
}
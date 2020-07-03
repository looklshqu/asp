using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Http_get_post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string urlInfo;
            urlInfo = "Http_get_post_result.aspx?irum=" + TextBox1.Text + "&email=" + TextBox2.Text;
            Response.Redirect(urlInfo);
        }
    }
}
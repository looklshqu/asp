using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Cookie_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "guest님 처음 방문을 환영합니다. ";
            }
            else
            {
                if (Request.Cookies["interest"] != null)
                {
                    Label1.Text = "guest님 지난번 관심영역은 " + Server.HtmlEncode(Request.Cookies["interest"].Value);
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("interest");
            cookie.Value = DropDownList1.SelectedItem.Text;
            cookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(cookie);
        }
    }
}
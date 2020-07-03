using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Application_object_result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Application.Get("qwe").ToString();
            int price;
            price = Int32.Parse(Application.Get("qwe").ToString()) * 27000;
            Response.Write("총판매금액 : " + price + "원");
        }
    }
}
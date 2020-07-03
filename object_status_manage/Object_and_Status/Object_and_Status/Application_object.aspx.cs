using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class Application_object : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            Application.Add("goods", "까베르네쇼비뇽");
            Application.Add("qwe", 5);
            Application.UnLock();
            TextBox1.Text = Application.Get("goods").ToString();
            TextBox2.Text = Application.Get("qwe").ToString();
        }
    }
}
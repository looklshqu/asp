using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Object_and_Status
{
    public partial class ViewState_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["intime"] = DateTime.Now;
                Label1.Text = "현재시간: " + ViewState["intime"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "처음 접속시간: " + ViewState["intime"] + "현재 종료 시간: " + DateTime.Now;
        }
    }
}
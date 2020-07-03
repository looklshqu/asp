using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_controll_1
{
    public partial class radioBtn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void r1_CheckedChanged(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                r1.Text = "예, 받아보겠습니다";
                r2.Text = "아니오";
            }
        }

        protected void r2_CheckedChanged(object sender, EventArgs e)
        {
            if (r2.Checked)
            {
                r1.Text = "예";
                r2.Text = "아니오, 받지않겠습니다";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_controll_1
{
    public partial class userTopTheme : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal1.Text = "트립토파즈 호텔과 함께 합니다.";
        }
    }
}
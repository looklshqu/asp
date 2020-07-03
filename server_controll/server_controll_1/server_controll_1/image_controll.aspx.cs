using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_controll_1
{
    public partial class image_controll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgBtn_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = " 이미지 클릭 위치 정보: " + "(" + e.X.ToString() + " , " + e.Y.ToString() + ")";
        }
    }
}
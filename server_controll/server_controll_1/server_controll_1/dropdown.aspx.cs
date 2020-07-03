using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_controll_1
{
    public partial class dropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str;
            if (DropDownList1.SelectedIndex <= 2)
            {
                str = "기본 지출 항목입니다. 물가상승에 주의하세요";
                //Response.Write("<span style='color:blue'>기본 지출 항목입니다. 물가상승에 주의하세요</span>");
            }
            else
            {
                str = "부수적 지출 항목입니다. 지출을 줄이세요";
                //Response.Write("<span style='color:red'>부수적 지출 항목입니다. 지출을 줄이세요</span>");
            }
            MessageBox.Showmsg(str, this.Page);
        }
    }
}
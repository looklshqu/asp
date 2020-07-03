using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_controll_1
{
    public partial class test_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = "접속하신 현재 날짜 시간은 " + DateTime.Now;

            //if (!IsPostBack)
            //{
            //    Label1.Text = " 반갑습니다 고객님 ";
            //}
            //else
            //{
            //    Label1.Text += " 접속하신 현재 날짜 시간은 " + DateTime.Now;
            //}
        }

        protected void btn_1_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = " 반갑습니다 고객님 ";
            }
            else
            {
                Label1.Text += " 접속하신 현재 날짜 시간은 " + DateTime.Now;
            }
        }
    }
}
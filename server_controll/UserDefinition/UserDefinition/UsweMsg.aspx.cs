using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefinition
{
    public partial class UsweMsg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(TextBox1.Text) >= 10)
            {
                MessageBox.setMessage("주문오류:주문수량은 10개 미만만 가능합니다", 0);
            }
            else
            {
                MessageBox.setMessage("주문성공: 주문이 성공적으로 이루어졌습니다.", 1);
            }
        }
    }
}
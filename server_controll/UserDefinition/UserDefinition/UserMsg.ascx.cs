using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefinition
{
    public partial class UserMsg : System.Web.UI.UserControl
    {
        public enum MessageType: int
        {
            Error = 0, Success = 1
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetMessage(string sMessage, int a)
        {
            if (a == 0)
            {
                Showmsg(sMessage, MessageType.Error);
            }
            else if (a == 1)
            {
                Showmsg(sMessage, MessageType.Success);
            }
        }
        public void Showmsg(string s, MessageType mType)
        {
            if (mType == MessageType.Error)
            {
                pnlMessage.CssClass = "msg message-error";
            }
            else if (mType == MessageType.Success)
            {
                pnlMessage.CssClass = "msg msg-success";
            }
            pnlMessage.Visible = (s.Length > 0);
            litMsg.Text = s;
            litMsg.Visible = true;
        }

        protected void btnOk_click(object sender, EventArgs e)
        {
            litMsg.Text = string.Empty;
            pnlMessage.Visible = false;
        }
    }
}
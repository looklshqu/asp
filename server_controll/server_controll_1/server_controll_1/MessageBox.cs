using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace server_controll_1
{
    public static class MessageBox
    {
        public static void Showmsg(string msgText, Page Mypage)
        {
            Mypage.ClientScript.RegisterStartupScript(Mypage.GetType(), "MesssageBox", "alert('" + msgText + "');", true);
        }
    }
}
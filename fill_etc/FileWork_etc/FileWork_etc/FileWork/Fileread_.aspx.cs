using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileWork_etc.FileWork
{
    public partial class Fileread_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string info = "D:\\order.txt";
            string a, b = string.Empty;
            FileStream file = new FileStream(info, FileMode.Open);
            StreamReader sin = new StreamReader(file, System.Text.Encoding.UTF8);
            do
            {
                a = sin.ReadLine();
                b = b + a + "\r\n";
            } while (a != null);
            sin.Close();
            TextBox1.Text = b;
        }
    }
}
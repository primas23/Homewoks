using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.PrintName
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Lb_Hello.Text = string.Empty;
        }

        protected void BtnPrintName(object sender, EventArgs e)
        {
            if (this.Txt_Name.Text.Length > 0)
            {
                this.Lb_Hello.Text = "Hello " + this.Txt_Name.Text;
            }
            else
            {
                this.Lb_Hello.Text = string.Empty;
            }
        }
    }
}
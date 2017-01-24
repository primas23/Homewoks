using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.HelloAsp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lb_Hello.Text = "Hello, ASP.NET";
            this.lb_assembly_location.Text = Assembly.GetExecutingAssembly().Location;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ASP.NET_Single_Page_application__SPA_.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

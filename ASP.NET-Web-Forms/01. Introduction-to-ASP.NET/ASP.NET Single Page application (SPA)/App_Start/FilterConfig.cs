using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Single_Page_application__SPA_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

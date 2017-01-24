using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Web_API_application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

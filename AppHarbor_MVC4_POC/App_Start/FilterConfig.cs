using System.Web;
using System.Web.Mvc;

namespace AppHarbor_MVC4_POC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
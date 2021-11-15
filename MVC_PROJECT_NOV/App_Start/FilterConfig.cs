using System.Web;
using System.Web.Mvc;

namespace MVC_PROJECT_NOV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

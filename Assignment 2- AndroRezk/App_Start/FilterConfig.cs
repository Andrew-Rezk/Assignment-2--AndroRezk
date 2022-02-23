using System.Web;
using System.Web.Mvc;

namespace Assignment_2__AndroRezk
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

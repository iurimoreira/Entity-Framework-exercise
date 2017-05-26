using System.Web;
using System.Web.Mvc;

namespace TP3_ASP_NET_Iuri_Moreira
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

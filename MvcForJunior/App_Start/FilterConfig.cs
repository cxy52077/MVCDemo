using System.Web;
using System.Web.Mvc;

namespace Better517Na.MVCExcerise.Junior.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
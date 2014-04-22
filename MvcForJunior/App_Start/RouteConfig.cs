using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Better517Na.MVCExcerise.Junior.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 注册路由的默认方法
            routes.MapRoute(
                // 路由名字
                name: "Default",
                // URL参数
                url: "{controller}/{action}/{id}",
                // 默认参数
                //defaults: new { controller = "RazorBasic", action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "RazorShow", action = "RazorView", id = UrlParameter.Optional }
            );
        }
    }
}
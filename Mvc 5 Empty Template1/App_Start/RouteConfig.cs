﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc_5_Empty_Template1.App_Start
{
    public class RouteConfig
    {
        public static void Configure(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Students", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
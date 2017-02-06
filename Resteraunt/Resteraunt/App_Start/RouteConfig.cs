using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Resteraunt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            "Product", // Route name
            "{controller}/{action}/{id}", // URL with parameters
            new { controller = "Product", action = "index" });


            //admin
            routes.MapRoute(
            "Admin", // Route name
            "{controller}/{action}/{id}", // URL with parameters
            new { controller = "Admin", action = "index" });
        }
    }
}

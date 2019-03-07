//---------------------------------------------------------------------------------
// <copyright file="RouteConfig" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//--------------------------------------------------------------------------------

namespace WebApp
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Route configuration for MVC part of application.
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Route server registration
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

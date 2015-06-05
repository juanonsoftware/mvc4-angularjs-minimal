﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AngularjsApp.MvcClient.App_Start;

namespace AngularjsApp.MvcClient
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Presentation
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

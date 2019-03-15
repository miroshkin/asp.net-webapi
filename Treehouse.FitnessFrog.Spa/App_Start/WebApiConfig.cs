using System.Web.Http;

namespace Treehouse.FitnessFrog.Spa
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                // api/entries/1
                routeTemplate: "api/{controller}/{id}",
                defaults:new {id = RouteParameter.Optional}
                );
        }
    }
}
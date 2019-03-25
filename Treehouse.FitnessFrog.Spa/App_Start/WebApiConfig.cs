using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Treehouse.FitnessFrog.Spa
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var jsonSerializerSettings = config.Formatters.JsonFormatter.SerializerSettings;
            jsonSerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.All;

            jsonSerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            //jsonSerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;

            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                // api/entries/1
                routeTemplate: "api/{controller}/{id}",
                defaults:new {id = RouteParameter.Optional}
                );
        }
    }
}
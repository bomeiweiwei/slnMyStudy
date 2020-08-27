using System.Web.Http;
using System.Web.Mvc;

namespace slnMyStudy.Areas.Service
{
    public class ServiceAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Service";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.Routes.MapHttpRoute(
                   name: "Service_Action",
                   routeTemplate: "Service/api/{controller}/{action}"
               );

            context.Routes.MapHttpRoute(
                    name: "Service_Controller",
                    routeTemplate: "Service/api/{controller}"
                );

            context.MapRoute(
                "Service_default",
                "Service/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
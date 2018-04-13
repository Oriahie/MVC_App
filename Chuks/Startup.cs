using Microsoft.Owin;
using Owin;
using CyberAcademy.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Chuks;
using Microsoft.Owin.Host.SystemWeb;

[assembly: OwinStartup(typeof(Startup))]
namespace CyberAcademy.Web
{
    public partial class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            //AreaRegistration.RegisterAllAreas();
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //FilterConfig.Configure(GlobalFilters.Filters);
            ConfigureAuth(app);
        }
    }
}
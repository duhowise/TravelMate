using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelMate.Web.Startup))]
namespace TravelMate.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

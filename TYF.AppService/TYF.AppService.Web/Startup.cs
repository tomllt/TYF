using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TYF.AppService.Web.Startup))]
namespace TYF.AppService.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

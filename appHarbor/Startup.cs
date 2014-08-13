using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appHarbor.Startup))]
namespace appHarbor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BundisoftWeb.Startup))]
namespace BundisoftWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

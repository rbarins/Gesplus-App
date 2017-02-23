using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gesplus_App.Startup))]
namespace Gesplus_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

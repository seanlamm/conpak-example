using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Conpak.Sam.Startup))]
namespace Conpak.Sam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iVault.App.Startup))]
namespace iVault.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

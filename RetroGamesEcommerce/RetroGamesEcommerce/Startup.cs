using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetroGamesEcommerce.Startup))]
namespace RetroGamesEcommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

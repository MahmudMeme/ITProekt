using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameAndGamer.Startup))]
namespace GameAndGamer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

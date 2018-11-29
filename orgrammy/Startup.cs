using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(orgrammy.Startup))]
namespace orgrammy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

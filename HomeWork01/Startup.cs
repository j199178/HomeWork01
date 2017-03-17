using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeWork01.Startup))]
namespace HomeWork01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

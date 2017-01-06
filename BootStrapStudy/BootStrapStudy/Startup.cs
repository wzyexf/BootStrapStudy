using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrapStudy.Startup))]
namespace BootStrapStudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

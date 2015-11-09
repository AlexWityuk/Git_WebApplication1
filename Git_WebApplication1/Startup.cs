using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_WebApplication1.Startup))]
namespace Git_WebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

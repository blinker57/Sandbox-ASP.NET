using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sandbox_ASP.NET.Startup))]
namespace Sandbox_ASP.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

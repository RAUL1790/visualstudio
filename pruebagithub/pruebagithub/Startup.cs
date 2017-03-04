using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebagithub.Startup))]
namespace pruebagithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

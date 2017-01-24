using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02.HelloAsp.Startup))]
namespace _02.HelloAsp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

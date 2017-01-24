using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.PrintName.Startup))]
namespace _01.PrintName
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

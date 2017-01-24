using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumNumbersASPMVC.Startup))]
namespace SumNumbersASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

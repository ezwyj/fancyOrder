using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FancyOrder.Startup))]
namespace FancyOrder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

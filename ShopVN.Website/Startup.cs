using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopVN.Website.Startup))]
namespace ShopVN.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

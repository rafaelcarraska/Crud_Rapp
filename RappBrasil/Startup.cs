using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RappBrasil.Startup))]
namespace RappBrasil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

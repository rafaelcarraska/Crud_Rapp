using Microsoft.Owin;
using Owin;
using System;
using Handson.Models;

[assembly: OwinStartupAttribute(typeof(Handson.Startup))]
namespace Handson
{
    public partial class Startup
    {
        public static Tuple<Suspeitos, Armas, Locais> Caso { get; set; }

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

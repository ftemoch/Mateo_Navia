using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParcialFinal.Startup))]
namespace ParcialFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

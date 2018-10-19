using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clase12.Startup))]
namespace Clase12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

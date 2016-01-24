using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEjemplo.Startup))]
namespace MVCEjemplo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

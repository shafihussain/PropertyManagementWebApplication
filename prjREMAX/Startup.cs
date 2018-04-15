using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prjREMAX.Startup))]
namespace prjREMAX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

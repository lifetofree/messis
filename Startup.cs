using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MESSIS.Startup))]
namespace MESSIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

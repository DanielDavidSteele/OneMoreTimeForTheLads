using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneMoreTimeForTheLads.Startup))]
namespace OneMoreTimeForTheLads
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

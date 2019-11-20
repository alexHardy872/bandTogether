using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bandTogether.Startup))]
namespace bandTogether
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

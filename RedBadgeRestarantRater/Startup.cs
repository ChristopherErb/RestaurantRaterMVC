using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedBadgeRestarantRater.Startup))]
namespace RedBadgeRestarantRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

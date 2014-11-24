using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunityIntelligence.Startup))]
namespace CommunityIntelligence
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

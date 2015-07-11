using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SummonerPlus.Startup))]
namespace SummonerPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HipKneeSurgeon.Startup))]
namespace HipKneeSurgeon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

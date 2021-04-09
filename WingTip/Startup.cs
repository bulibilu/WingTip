using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingTip.Startup))]
namespace WingTip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
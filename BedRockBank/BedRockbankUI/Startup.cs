using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BedRockbankUI.Startup))]
namespace BedRockbankUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

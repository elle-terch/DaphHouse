using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DaphHouseUI.Startup))]
namespace DaphHouseUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

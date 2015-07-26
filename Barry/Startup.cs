using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Barry.Startup))]
namespace Barry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

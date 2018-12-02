using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReFreshAir1.Startup))]
namespace ReFreshAir1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

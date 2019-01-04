using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Antrian.Startup))]
namespace Antrian
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

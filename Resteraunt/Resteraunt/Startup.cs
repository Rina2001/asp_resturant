using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resteraunt.Startup))]
namespace Resteraunt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

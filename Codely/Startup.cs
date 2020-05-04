using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Codely.Startup))]
namespace Codely
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

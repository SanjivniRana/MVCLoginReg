using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLoginReg.Startup))]
namespace MvcLoginReg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

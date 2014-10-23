using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityRoles.Startup))]
namespace IdentityRoles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

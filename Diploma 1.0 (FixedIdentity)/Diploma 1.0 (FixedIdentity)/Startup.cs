using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Diploma_1._0__FixedIdentity_.Startup))]
namespace Diploma_1._0__FixedIdentity_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

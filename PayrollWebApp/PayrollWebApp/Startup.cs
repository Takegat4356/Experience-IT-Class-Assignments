using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayrollWebApp.Startup))]
namespace PayrollWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

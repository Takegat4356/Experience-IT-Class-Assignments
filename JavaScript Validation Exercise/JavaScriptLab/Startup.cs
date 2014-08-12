using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JavaScriptLab.Startup))]
namespace JavaScriptLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

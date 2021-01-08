using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMidTerm.Startup))]
namespace MVCMidTerm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

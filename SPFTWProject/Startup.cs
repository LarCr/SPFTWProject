using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SPFTWProject.Startup))]
namespace SPFTWProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

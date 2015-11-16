using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstRunFinalProject.Startup))]
namespace FirstRunFinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

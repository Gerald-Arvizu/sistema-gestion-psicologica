using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaWebPsicologia.Startup))]
namespace SistemaWebPsicologia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

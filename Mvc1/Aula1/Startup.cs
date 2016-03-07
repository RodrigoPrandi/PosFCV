using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula1.Startup))]
namespace Aula1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutenticacaoIdentity.Startup))]
namespace AutenticacaoIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

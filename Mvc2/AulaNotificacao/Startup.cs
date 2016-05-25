using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AulaNotificacao.Startup))]
namespace AulaNotificacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

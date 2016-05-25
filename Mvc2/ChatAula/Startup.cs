using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatAula.Startup))]
namespace ChatAula
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}

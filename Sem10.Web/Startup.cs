using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sem10.Web.Startup))]
namespace Sem10.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(examenAnalista.Startup))]
namespace examenAnalista
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

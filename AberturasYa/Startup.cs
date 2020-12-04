using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AberturasYa.Startup))]
namespace AberturasYa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

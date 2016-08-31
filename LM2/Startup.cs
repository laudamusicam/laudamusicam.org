using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LM2.Startup))]
namespace LM2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

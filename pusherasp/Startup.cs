using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pusherasp.Startup))]
namespace pusherasp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(refactoradiyos_final.Startup))]
namespace refactoradiyos_final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestOpensearch.Startup))]
namespace TestOpensearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

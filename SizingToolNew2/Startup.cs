using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SizingToolNew2.Startup))]
namespace SizingToolNew2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

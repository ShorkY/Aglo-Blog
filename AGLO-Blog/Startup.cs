using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AGLO_Blog.Startup))]
namespace AGLO_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

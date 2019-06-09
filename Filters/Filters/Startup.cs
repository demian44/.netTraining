using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filters.Startup))]
namespace Filters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

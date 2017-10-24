using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week5_Day2.Startup))]
namespace Week5_Day2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

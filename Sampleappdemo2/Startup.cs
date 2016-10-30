using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sampleappdemo2.Startup))]
namespace Sampleappdemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

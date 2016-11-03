using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comp229_F2016_Lesoon8.Startup))]
namespace Comp229_F2016_Lesoon8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

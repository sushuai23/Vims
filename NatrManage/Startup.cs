using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NatrManage.Startup))]
namespace NatrManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcFireField.Startup))]
namespace MvcFireField
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

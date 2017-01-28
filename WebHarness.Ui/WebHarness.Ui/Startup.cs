using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHarness.Ui.Startup))]
namespace WebHarness.Ui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuirkyBookRentalApp.Startup))]
namespace QuirkyBookRentalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

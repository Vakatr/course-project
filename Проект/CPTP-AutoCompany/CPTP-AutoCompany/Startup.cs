using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CPTP_AutoCompany.Startup))]
namespace CPTP_AutoCompany
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

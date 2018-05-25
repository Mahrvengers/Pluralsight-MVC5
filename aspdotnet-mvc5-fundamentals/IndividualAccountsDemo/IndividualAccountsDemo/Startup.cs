using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndividualAccountsDemo.Startup))]
namespace IndividualAccountsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

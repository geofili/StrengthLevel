using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StrengthLevel.Startup))]
namespace StrengthLevel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

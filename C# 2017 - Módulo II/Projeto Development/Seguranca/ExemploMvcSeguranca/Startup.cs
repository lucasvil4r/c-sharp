using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploMvcSeguranca.Startup))]
namespace ExemploMvcSeguranca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

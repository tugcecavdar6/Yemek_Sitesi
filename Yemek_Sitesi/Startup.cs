using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yemek_Sitesi.Startup))]
namespace Yemek_Sitesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

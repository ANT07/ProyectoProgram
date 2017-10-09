using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoProgram.Startup))]
namespace ProyectoProgram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

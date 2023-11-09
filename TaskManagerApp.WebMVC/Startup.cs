using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskManagerApp.WebMVC.Startup))]
namespace TaskManagerApp.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

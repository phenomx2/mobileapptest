using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(apntestfordocsService.Startup))]

namespace apntestfordocsService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
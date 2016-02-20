using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(uwpstoriesService.Startup))]

namespace uwpstoriesService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
            app.MapSignalR();
        }
    }
}
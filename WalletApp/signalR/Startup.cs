using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using WalletApp.signalR;
[assembly: OwinStartup(typeof(SignalRChat.Startup))]
namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.HubPipeline.AddModule(new ErrorHandlingPipelineModule());

            app.MapSignalR();
        }
    }
}
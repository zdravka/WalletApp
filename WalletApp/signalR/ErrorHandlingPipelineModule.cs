using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WalletApp.signalR
{
    public class ErrorHandlingPipelineModule : HubPipelineModule
    {
        protected override void OnIncomingError(ExceptionContext ex, IHubIncomingInvokerContext context)
        {
            Debug.WriteLine("=> Exception " + ex.ToString());
            if (ex.ToString() != null)
            {
                Debug.WriteLine("=> Inner Exception " + ex.ToString());
            }
            base.OnIncomingError(ex,context);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using WalletApp.Controllers;

namespace WalletApp.signalR
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            if (message.Contains("<script>"))
            {
                throw new HubException("This message will flow to the client", new { user = Context.User.Identity.Name, message = message });
            }
            
            Clients.All.broadcastMessage(name, message);
        }
    }
}
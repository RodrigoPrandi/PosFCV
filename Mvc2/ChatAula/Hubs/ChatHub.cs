using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatAula.Hubs
{
    public class ChatHub : Hub
    {
        public void Entrar(string name)
        {
            Clients.All.join(name, DateTime.UtcNow.AddHours(-3).ToString("HH:mm"));
        }
        public void Sair(string name)
        {
            Clients.All.logoff(name, DateTime.UtcNow.AddHours(-3).ToString("HH:mm"));
        }
        public void EnviarMensagem(string msg, string name)
        {
            Clients.All.receberMensagem(msg, name, DateTime.UtcNow.AddHours(-3).ToString("HH:mm"));
        }
    }
}
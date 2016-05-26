using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Hubs
{
    public class NotificationHub : Hub
    {
        private Contexto db = new Contexto();
        public void Refresh()
        {
            Clients.Caller.refresh(db.Tarefas.ToList());
        }

        public void Done(int id)
        {
            try
            {
                var model = db.Tarefas.Find(id);

                model.Done = true;

                db.SaveChanges();

                Clients.Others.todoDone($@"O usuário {model.Pessoa.Nome} concluiu a tarefa {model.Nome}");
                Clients.All.done(id);
            }
            catch (Exception ex)
            {
                Clients
                    .Caller
                    .error(
                        string.IsNullOrWhiteSpace(ex.Message)
                        ? ex.InnerException.Message
                        : ex.Message);
            }
        }
    }
}
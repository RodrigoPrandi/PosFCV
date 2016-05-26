using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;
using TrabalhoFinal.Hubs;
using Microsoft.AspNet.SignalR;

namespace TrabalhoFinal.Controllers
{
    [System.Web.Mvc.Authorize]
    public class TarefasController : Controller
    {
        private Contexto db = new Contexto();
        IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();

        // GET: Tarefas
        public async Task<ActionResult> Index()
        {
            var tarefas = db.Tarefas.Include(t => t.Pessoa);
            return View(await tarefas.ToListAsync());
        }

        // GET: Tarefas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefa tarefa = await db.Tarefas.FindAsync(id);
            if (tarefa == null)
            {
                return HttpNotFound();
            }
            return View(tarefa);
        }

        // GET: Tarefas/Create
        public ActionResult Create()
        {
            ViewBag.PessoaId = new SelectList(db.Pessoas, "Id", "Nome");
            return View();
        }

        // POST: Tarefas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Descricao,Done,PessoaId")] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                db.Tarefas.Add(tarefa);
                await db.SaveChangesAsync();

                hubContext.Clients.All.todoCreated(string.Format("O usuário {0}, criou a tarefa {1}", User.Identity.Name, tarefa.Nome));

                return RedirectToAction("Index");
            }

            ViewBag.PessoaId = new SelectList(db.Pessoas, "Id", "Nome", tarefa.PessoaId);
            return View(tarefa);
        }

        // GET: Tarefas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefa tarefa = await db.Tarefas.FindAsync(id);
            if (tarefa == null)
            {
                return HttpNotFound();
            }
            ViewBag.PessoaId = new SelectList(db.Pessoas, "Id", "Nome", tarefa.PessoaId);
            return View(tarefa);
        }

        // POST: Tarefas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nome,Descricao,Done,PessoaId")] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarefa).State = EntityState.Modified;
                await db.SaveChangesAsync();

                hubContext.Clients.All.todoModified(string.Format("O usuário {0}, alterou a tarefa {1}", User.Identity.Name, tarefa.Nome));

                return RedirectToAction("Index");
            }
            ViewBag.PessoaId = new SelectList(db.Pessoas, "Id", "Nome", tarefa.PessoaId);
            return View(tarefa);
        }

        // GET: Tarefas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefa tarefa = await db.Tarefas.FindAsync(id);
            if (tarefa == null)
            {
                return HttpNotFound();
            }
            return View(tarefa);
        }

        // POST: Tarefas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Tarefa tarefa = await db.Tarefas.FindAsync(id);
            db.Tarefas.Remove(tarefa);
            await db.SaveChangesAsync();
            hubContext.Clients.All.todoDeleted(string.Format("O usuário {0}, excluiu a tarefa {1}", User.Identity.Name, tarefa.Nome));
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
